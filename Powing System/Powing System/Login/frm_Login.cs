using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Powing_System
{
    public partial class frm_Login : Form
    {
        Officer ObjOff = new Officer();

        public frm_Login()
        {
            InitializeComponent();
        }

        public static string uid = "";
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = ObjOff.selectUser(txtUserName.Text);
            while(dr.Read() == true)
            {
                string password = dr["password"].ToString();
                if (txtPassword.Text == password && txtUserName.Text != "Administrator")
                {
                    uid = txtUserName.Text;
                    frmMain fm = new frmMain();
                    fm.Show();


                    this.Hide();
                }
                else if (txtPassword.Text == password && txtUserName.Text == "Administrator")
                {
                    uid = txtUserName.Text;
                    frmMain fm = new frmMain();
                    fm.Show();


                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter Correct details!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUserName.Clear();
                }
            }

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip1.Show("Please enter correct details!", txtUserName, 0, -50, 700);
                e.Handled = true;
            }
        }
    }
}
