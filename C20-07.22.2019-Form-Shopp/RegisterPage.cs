using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C20_07._22._2019_Form_Shopp.Model;
namespace C20_07._22._2019_Form_Shopp
{
    public partial class RegisterPage : Form
    {
        c20ShoppingEntities db = new c20ShoppingEntities();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;
            string[] arrayList = new string[] { fullname, email, phone, password, repeatPassword };
           bool checkedInput= Extensions.CheckInput(arrayList, string.Empty);
            if (checkedInput)
            {
                lblError.Visible = false;
                if (password == repeatPassword)
                {
                    if (password.Length > 5)
                    {
                        User selectUser = db.Users.FirstOrDefault(u=>u.Email==email);
                        if (selectUser == null)
                        {
                           
                            db.Users.Add(new User
                            {
                                Fullname=fullname,
                                Email=email,
                                Password=password.HashPsw(),
                                Phone=phone,

                            });
                            db.SaveChanges();
                            MessageBox.Show("User was successfully added. ","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            lblError.Text = "Email already Exsist !";
                            lblError.Visible = true;
                        }
                     
                    }
                    else
                    {
                        lblError.Text = "Password lengt must be 5 charachter ";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Password and Repeat Password aren't same";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please all the Fill";
                lblError.Visible = true;
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<48 || e.KeyChar>57) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
