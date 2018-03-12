using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powing_System
{
    public partial class frm_splashscreen : Form
    {
        frm_Login flg = new frm_Login();

        public frm_splashscreen()
        {
            InitializeComponent();
        }

        private void frm_splashscreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
            progressBar1.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
                progressBar1.Value++;
            else
            {
                flg.Show();


                timer1.Stop();
                this.Hide();
            }
        }
    }
}
