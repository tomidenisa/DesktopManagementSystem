using CRUDOP2.Models;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static CRUDOP2.Registration;


namespace CRUDOP2
{
    public partial class Appointment : Form
    {
        
        public Appointment()
        {
            InitializeComponent();

        }
     
        ServiceAutoDBEntities db = new ServiceAutoDBEntities();
        Angajat employee = new Angajat();
        pozitie_angajat pozitie = new pozitie_angajat();
        Punct_Lucru_Service pct_lucru = new Punct_Lucru_Service();
        programare appointment = new programare();
        int id_programare = 0;
        Color greenColor = ColorTranslator.FromHtml("#00FF00");
        Color redColor = ColorTranslator.FromHtml("#ff033d");
        Color blueColor = ColorTranslator.FromHtml("#4f03ff");
        string connectionString = DataBaseConnection.ConnectionString;

        private void Appointment_Load(object sender, EventArgs e)
        {
            BindEmployeeComboBox();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                this.punct_Lucru_ServiceTableAdapter.Connection = connection;
                this.punct_Lucru_ServiceTableAdapter.Fill(this.serviceAutoDBDataSet.Punct_Lucru_Service);

                
                this.pozitie_angajatTableAdapter.Connection = connection;
                this.pozitie_angajatTableAdapter.Fill(this.serviceAutoDBDataSet.pozitie_angajat);

                
                this.angajatTableAdapter.Connection = connection;
                this.angajatTableAdapter.Fill(this.serviceAutoDBDataSet.Angajat);
            }
            ClearData();
            SetDataInGridView();
            SetAppointmentColors();
            this.WindowState = FormWindowState.Maximized;
            UserRole currentUserRole = UserManager.CurrentUserRole;
            if (currentUserRole == UserRole.User)
            {
                Delete.Visible = false; 
                AdminButton.Visible = false;
                Search.Visible = false;
                SearchBtn.Visible = false;
                Add.Visible = false;

            }
           
            
        }
        private void BindEmployeeComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Nume + ' ' + Prenume AS NumeComplet FROM Angajat";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    EmployeeCombo.DataSource = dataTable;
                    EmployeeCombo.DisplayMember = "NumeComplet";
                    EmployeeCombo.ValueMember = "Id";
                }
                connection.Close();
            }
            
        }
        private void SetAppointmentColors()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Status"].Value != null && row.Cells["Status"].Value.ToString() == "In Asteptare")
                {
                    row.DefaultCellStyle.BackColor = redColor;
                }
                else if (row.Cells["Status"].Value != null && row.Cells["Status"].Value.ToString() == "In Progres")
                {
                    row.DefaultCellStyle.BackColor = blueColor;
                }
                else if (row.Cells["Status"].Value != null && row.Cells["Status"].Value.ToString() == "Finalizat")
                {
                    row.DefaultCellStyle.BackColor = greenColor;
                }
            }
        }
        public void ClearData()
        {
            OnlineOnsiteCombo.Text = INTimePicker.Text = OUTTimePicker.Text  = PozitieTextBox.Text = PctLucruTextBox.Text = string.Empty;
            EmployeeCombo.SelectedIndex = -1;
            Add.Text = "Salveaza";
            id_programare = 0;
        }
        int userId = UserManager.CurrentUserID;
        private RabbitMQSender _client;
        private RabbitMQSender _clientWrite;
        private void CreateWriteClient()
        {
            if (_clientWrite == null)
                _clientWrite = CreateClient();
        }
        private RabbitMQSender CreateClient()
        {
            return new RabbitMQSender();
        }
        public void SetDataInGridView()
        {
            dataGridView.AutoGenerateColumns = false;

            if (UserManager.CurrentUserRole == UserRole.User)
            {
                int currentUserId = UserManager.CurrentUserID;
                dataGridView.DataSource = db.programares.Where(p => p.angajat_id == currentUserId).ToList<programare>();
            }
            else if (UserManager.CurrentUserRole == UserRole.Admin)
            {
                dataGridView.DataSource = db.programares.ToList<programare>();
            }

            SetAppointmentColors();

        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home formhomp = new Home();
            formhomp.Show();
        }

        private void ProgramButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment formApp = new Appointment();
            formApp.Show();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Product formProduct = new Product();
            formProduct.Show();
        }

        private void OfferButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Offer formOffer = new Offer();

            formOffer.Show();
        }

        private void DevizButton_Click(object sender, EventArgs e)
        {
            Deviz formDeviz = new Deviz();
            this.Hide();
            formDeviz.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            Management formmgmt = new Management();
            this.Hide();
            formmgmt.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Registration formRegi = new Registration();
            this.Hide();
            formRegi.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            string punctLucruName = PctLucruTextBox.Text.Trim();
            int punctLucruId = db.Punct_Lucru_Service.FirstOrDefault(p => p.Denumire == punctLucruName)?.Punct_Lucru_Id ?? 0;
            string pozitieName = PozitieTextBox.Text.Trim();
            int pozitieId = db.pozitie_angajat.FirstOrDefault(p => p.pozitie == pozitieName)?.pozitie_angajat_id ?? 0;
            TimeSpan intrare = INTimePicker.Value.TimeOfDay;
            TimeSpan iesire = OUTTimePicker.Value.TimeOfDay;
            appointment.online_onsite = OnlineOnsiteCombo.Text.Trim();
            appointment.ora_intrare = intrare;
            appointment.ora_iesire = iesire;
            appointment.data_programare = DateTime.Parse(AppointmentDate.Text.Trim());
            appointment.angajat_id = Convert.ToInt32(EmployeeCombo.SelectedValue);
            appointment.pozitie_angajat_id = pozitieId;
            appointment.data_inregistrare = DateTime.Now;
            appointment.id_pct_lucru_service = punctLucruId;
            DateTime dataProgramare = DateTime.Parse(AppointmentDate.Text.Trim());
            int selectedEmployeeId = Convert.ToInt32(EmployeeCombo.SelectedValue);
            bool hasConflictingAppointment = db.programares.Any(p =>
    p.data_programare != null &&
    EntityFunctions.TruncateTime(p.data_programare) == EntityFunctions.TruncateTime(dataProgramare) &&
    p.angajat_id == selectedEmployeeId &&
    (
      
        (p.ora_intrare == intrare || p.ora_iesire == iesire) ||

       
        (p.ora_intrare < intrare && intrare < p.ora_iesire) ||

        
        (p.ora_intrare < iesire && iesire < p.ora_iesire) ||

        
        (intrare < p.ora_intrare && p.ora_iesire < iesire)
    ));


            if (hasConflictingAppointment)
            {
                MessageBox.Show("Exista deja o programare in acelasi interval orar pentru angajatul selectat.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id_programare > 0)
                db.Entry(appointment).State = EntityState.Modified;
            else
            {
                db.programares.Add(appointment);
                appointment.status = "In Asteptare";
            }
            if (  EmployeeCombo.SelectedItem==null)
            {
                MessageBox.Show("Selecteaza o valoare pentru angajat, pozitie si punct de lucru.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.SaveChanges();
            ClearData();
            SetDataInGridView();
            MessageBox.Show("Inregistrare salvata cu succes");
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Status"].Value != null && row.Cells["Status"].Value.ToString() == "In Asteptare")
                {
                    row.DefaultCellStyle.BackColor = redColor;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea ?", "Sterge ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                db.programares.Remove(appointment);
                db.SaveChanges();
                ClearData();
                SetDataInGridView();
                MessageBox.Show("Inregistrare stearsa cu succes");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza o programare pentru a fi acceptata.");
                return; 
            }
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int appointmentId = Convert.ToInt32(dataGridView[0, selectedRowIndex].Value);
                var appointment = db.programares.FirstOrDefault(a => a.id == appointmentId);

                if (appointment != null)
                {
                    int employeeId = appointment.angajat_id;
                    var employee = db.Angajats.FirstOrDefault(f => f.Id == employeeId);

                    if (employee != null)
                    {
                        string employeeName = employee.Nume;
                        int positionId = employee.Id_Pozitie_Angajat;
                        var position = db.pozitie_angajat.FirstOrDefault(p => p.pozitie_angajat_id == positionId);

                        if (position != null)
                        {
                            string positionName = position.pozitie;
                            int branchId = employee.IdPunctDeLucru;
                            var branch = db.Punct_Lucru_Service.FirstOrDefault(b => b.Punct_Lucru_Id == branchId);

                            if (branch != null)
                            {
                                string branchName = branch.Denumire;
                                string message = $"Esti sigur ca vrei sa accepti programarea pentru angajatul {employeeName} cu pozitia {positionName} la punctul de lucru {branchName}?";
                                DialogResult result = MessageBox.Show(message, "Confirmare acceptare programare", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {
                                    if (appointment.status == "In Asteptare")
                                    {
                                        appointment.status = "In Progres";
                                        dataGridView.Rows[selectedRowIndex].DefaultCellStyle.BackColor = blueColor;
                                        db.SaveChanges();
                                        MessageBox.Show("Statusul programarii schimbat in 'In Progress'.");
                                    }
                                    else if (appointment.status == "Finalizat")
                                    {
                                        MessageBox.Show("Programarea a fost deja finalizata.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Statusul programarii nu poate fi schimbat.");
                                    }


                                    try
                                    {
                                        
                                        DateTime selectedDate = System.DateTime.Now;
                                        
                                        CreateWriteClient();
                                        var messages = $"Angajatul {employeeName} a acceptat programarea {appointmentId} la {selectedDate}";
                                        _clientWrite.Write("administrator", messages, "admin1");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void SendMessageToRabbitMQ(string angajatName, int programareId)
        {
            try
            {
                var sender = new RabbitMQSender("localhost", "guest", "guest");

                string message = $"Angajatul {angajatName} a actualizat programarea {programareId}";

                sender.Write("administrator_queue", message,"admin1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("RabbitMQ error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void EmployeeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeCombo.SelectedValue == null)
            {
                return;
            }
            int employeeId = (int)EmployeeCombo.SelectedValue;
            employee = db.Angajats.FirstOrDefault(a => a.Id == employeeId);
            pozitie = db.pozitie_angajat.FirstOrDefault(pa => pa.pozitie_angajat_id == employee.Id_Pozitie_Angajat);
            pct_lucru = db.Punct_Lucru_Service.FirstOrDefault(p => p.Punct_Lucru_Id == employee.IdPunctDeLucru);
            PozitieTextBox.Text = pozitie.pozitie;
            PctLucruTextBox.Text = pct_lucru.Denumire;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int appointmentId = Convert.ToInt32(dataGridView[0, selectedRowIndex].Value);
                var appointment = db.programares.FirstOrDefault(a => a.id == appointmentId);

                if (appointment != null)
                {
                    int employeeId = appointment.angajat_id;
                    var employee = db.Angajats.FirstOrDefault(f => f.Id == employeeId);
                    if (employee != null)
                    {
                        string employeeName = employee.Nume;
                        int positionId = employee.Id_Pozitie_Angajat;
                        var position = db.pozitie_angajat.FirstOrDefault(p => p.pozitie_angajat_id == positionId);
                        if (position != null)
                        {
                            string positionName = position.pozitie;
                            int branchId = employee.IdPunctDeLucru;
                            var branch = db.Punct_Lucru_Service.FirstOrDefault(b => b.Punct_Lucru_Id == branchId);
                            if (branch != null)
                            {
                                string branchName = branch.Denumire;
                                string message = $"Esti sigur ca vrei sa finalizati programarea pentru angajatul {employeeName} cu pozitia {positionName} la punctul de lucru {branchName}?";
                                DialogResult result = MessageBox.Show(message, "Confirmare finalizare programare", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    if (appointment.status == "In Progres")
                                    {
                                        appointment.status = "Finalizat";
                                        dataGridView.Rows[selectedRowIndex].DefaultCellStyle.BackColor = greenColor;
                                        db.SaveChanges();
                                        MessageBox.Show("Statusul programarii schimbat in 'Finalizata'.");
                                    }
                                }
                                else if (appointment.status == "Finalizat")
                                {
                                    MessageBox.Show("Programarea a fost deja finalizata.");
                                }
                                else
                                {
                                    MessageBox.Show("Statusul programarii nu poate fi schimbat.");
                                }
                                try
                                {

                                    DateTime selectedDate = System.DateTime.Now;

                                    CreateWriteClient();
                                    var messages = $"Angajatul {employeeName} a finalizat programarea {appointmentId} la {selectedDate}";
                                    _clientWrite.Write("administrator", messages, "admin1");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Nu se poate gasi programarea.");
                }
            }
            else
            {
                MessageBox.Show("Selecteaza o programare pentru a fi finalizata.");
            }
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string employeeName1 = Search.Text.Trim();
            int employeeId = db.Angajats.FirstOrDefault(a => a.Nume == employeeName1)?.Id ?? 0;
            int searchValue = employeeId;
            dataGridView.ClearSelection();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = true;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToInt32(row.Cells[6].Value) == searchValue)
                    {
                        row.Selected = true;
                        valueResult = false;
                        //break;

                    }
                }
                if (valueResult != false)
                {
                    MessageBox.Show("Inregistrare inexistenta pentru cautarea " + Search.Text, " Nu exista");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex != -1)
            {
                id_programare = Convert.ToInt32(dataGridView.CurrentRow.Cells["IdAngajat"].Value);
                appointment = db.programares.Where(x => x.id == id_programare).FirstOrDefault();
                OnlineOnsiteCombo.SelectedValue = appointment.online_onsite;
                EmployeeCombo.SelectedValue = appointment.angajat_id;

                if (appointment.status == "Finalizat")
                {
                    MessageBox.Show("Aceasta programare nu poate fi actualizata pentru ca a fost deja finalizata.");
                    return;
                }
                else
                {
                    Add.Text = "Update";
                    Delete.Enabled = true;

                }
            }

        }

        private void refusebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int appointmentId = Convert.ToInt32(dataGridView[0, selectedRowIndex].Value);
                var appointment = db.programares.FirstOrDefault(a => a.id == appointmentId);

                if (appointment != null)
                {
                    int employeeId = appointment.angajat_id;
                    var employee = db.Angajats.FirstOrDefault(f => f.Id == employeeId);
                    if (employee != null)
                    {
                        string employeeName = employee.Nume;
                        int positionId = employee.Id_Pozitie_Angajat;
                        var position = db.pozitie_angajat.FirstOrDefault(p => p.pozitie_angajat_id == positionId);
                        if (position != null)
                        {
                            string positionName = position.pozitie;
                            int branchId = employee.IdPunctDeLucru;
                            var branch = db.Punct_Lucru_Service.FirstOrDefault(b => b.Punct_Lucru_Id == branchId);
                            if (branch != null)
                            {
                                string branchName = branch.Denumire;
                                string message = $"Esti sigur ca vrei sa refuzi programarea pentru angajatul {employeeName} cu pozitia {positionName} la punctul de lucru {branchName}?";
                                DialogResult result = MessageBox.Show(message, "Confirmare refuzare programare", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    if (appointment.status == "In Asteptare")
                                    {
                                        MessageBox.Show("Programare refuzata");
                                    }
                                }
                                else if (appointment.status == "Finalizat")
                                {
                                    MessageBox.Show("Programarea a fost deja finalizata.");
                                }
                                else
                                {
                                    MessageBox.Show("Statusul programarii nu poate fi schimbat.");
                                }
                                try
                                {

                                    DateTime selectedDate = System.DateTime.Now;

                                    CreateWriteClient();
                                    var messages = $"Angajatul {employeeName} a refuzat programarea {appointmentId} la {selectedDate}";
                                    _clientWrite.Write("administrator", messages, "admin1");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("rabbit fail " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Nu se poate gasi programarea.");
                }
            }
            else
            {
                MessageBox.Show("Selecteaza o programare pentru a fi finalizata.");
            }

        }
    }
}
