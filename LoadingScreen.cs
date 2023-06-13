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
        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                // Update progress bar
                progressBar1.Increment(1);

                // Update message label based on progress bar value
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

                // Check if loading is complete
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    // Stop timer
                    timer1.Stop();

                    // Open home form
                    Registration reg = new Registration();
                    reg.Show();
                    this.Hide();
            }

        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
