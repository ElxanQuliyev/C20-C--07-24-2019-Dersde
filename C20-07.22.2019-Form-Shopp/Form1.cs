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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to Our Shop App!";
            pbImage.Image = new Bitmap(@"C:\Users\User\source\repos\C20-07.22.2019-Form-Shopp\C20-07.22.2019-Form-Shopp\Image\image1.png");
            pbImage.Location = new Point(pbImage.Parent.ClientSize.Width / 2 - pbImage.Size.Width / 2,
                pbImage.Parent.ClientSize.Height / 2 - pbImage.Size.Height / 2

                );
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterPage rg = new RegisterPage();
            rg.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginPage lg = new LoginPage();
            lg.ShowDialog();
        }
    }
}
