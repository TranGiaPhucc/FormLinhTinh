using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Login : Form
    {
        BLLDangNhap bllDangNhap = new BLLDangNhap();
        QLDangNhapDataContext qldn = new QLDangNhapDataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            var user = (from u in qldn.DangNhaps where u.Username.Equals(username) select u).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) == true || string.IsNullOrWhiteSpace(textBoxPassword.Text) == true)
            {
                MessageBox.Show("Các trường nhập không được để trống.");
            }
            else if (user == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.");
            }
            else if (!user.Password.Equals(password))
            {
                MessageBox.Show("Sai mật khẩu.");
            }
            else
            {
                this.Hide();
                Main m = new Main();
                m.ShowDialog();
                this.Close();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register dk = new Register();
            dk.ShowDialog();

        }
    }
}
