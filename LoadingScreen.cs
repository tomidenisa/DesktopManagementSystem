using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace CRUDOP2
{
    public partial class LoadingScreen : Form
    {
        private int carXPosition;
        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
            carXPosition = carPictureBox.Location.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                
                progressBar1.Increment(1);

                
                int progress = progressBar1.Value;
            if (progress < 25)
                {
                    loadinglabel.Text = "Se bea cafeaua...";
                }
                else if (progress < 50)
                {
                    loadinglabel.Text = "Se echipeaza mecanicii...";
                }
                else if (progress < 80)
                {
                    loadinglabel.Text = "Se verifica elevatorul...";
                }
                else
                {
                    loadinglabel.Text = "Incepem treaba!";
                }

               
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    
                    timer1.Stop();

                    
                    Registration reg = new Registration();
                    reg.Show();
                    this.Hide();
            }
            carXPosition += 3; 
            carPictureBox.Location = new Point(carXPosition, carPictureBox.Location.Y);

            
            if (progressBar1.Value == progressBar1.Maximum)
            {
                
                timer1.Stop();

                
                Registration reg = new Registration();
                reg.Show();
                this.Hide();
            }

        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
