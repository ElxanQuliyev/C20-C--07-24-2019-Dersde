using C20_07._22._2019_Form_Shopp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20_07._22._2019_Form_Shopp
{
    public partial class LoginPage : Form
    {
        c20ShoppingEntities db = new c20ShoppingEntities();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (Extensions.CheckInput(new string[] {
            email,password}, string.Empty))
            {
                User selectUser = db.Users.FirstOrDefault(us => us.Email == email);
                Setting adminSelect = db.Settings.Find(1);
                if (adminSelect.AdminEmail == email && adminSelect.AdminPassword == password.HashPsw())
                {
                    AdminDashboard adm = new AdminDashboard();
                    adm.ShowDialog();
                }
                else
                {
                    if (selectUser != null)
                    {
                        if (selectUser.Password == password.HashPsw())
                        {
                            if (chkRemember.Checked)
                            {
                                Properties.Settings.Default.email = email;
                                Properties.Settings.Default.password = password;
                                Properties.Settings.Default.checkedBox = true;
                                Properties.Settings.Default.Save();

                            }
                            else
                            {
                                Properties.Settings.Default.email = "";
                                Properties.Settings.Default.password = "";
                                Properties.Settings.Default.checkedBox = false;
                                Properties.Settings.Default.Save();

                            }

                            Dashboard ds = new Dashboard();
                            ds.ShowDialog();
                        }
                        else
                        {
                            lblError.Text = "Password doesn't correct!";
                            lblError.Visible = true;
                        }
                    }
                    else
                    {
                        lblError.Text = "Email doesn't correct!";
                        lblError.Visible = true;
                    }
                }
            }
            else
            {
                lblError.Text = "Please all the Fill";
                lblError.Visible = true;
            }
            }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.checkedBox)
            {
                txtEmail.Text = Properties.Settings.Default.email;
                txtPassword.Text = Properties.Settings.Default.password;
                chkRemember.Checked = true;

            }
        }
    }
}
