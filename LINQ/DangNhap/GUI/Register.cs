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
    public partial class Register : Form
    {
        QLDangNhapDataContext qldn = new QLDangNhapDataContext();
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            var user = (from u in qldn.DangNhaps where u.Username.Equals(username) select u).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) == true ||  string.IsNullOrWhiteSpace(textBoxPassword.Text) == true || string.IsNullOrWhiteSpace(textBoxConfirm.Text) == true)
            {
                MessageBox.Show("Các trường nhập không được để trống.");
            }
            else if (user != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại.");
            }
            else if (textBoxConfirm.ToString().Equals(textBoxPassword.ToString()) == false)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp.");
            }
            else {
                DangNhap dn = new DangNhap();
                dn.Username = username;
                dn.Password = password;
                qldn.DangNhaps.InsertOnSubmit(dn);
                qldn.SubmitChanges();
                MessageBox.Show("Đăng ký mới thành công.");
                this.Close();
            }
            
        }
    }
}
