using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //dung activity click de khi nguoi dung click thi phuong thuc se duoc goi
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txbUsername.Text;
            string MatKhau = txbPassword.Text;
            //lay 2 bien de la du lieu tu textbox de cho nguoi dung truy cap
            //sau do cho so sanh voi du lieu cua ta neu dung xuat ra thong bao
            if (TaiKhoan == "admin" && MatKhau == "admin")
                MessageBox.Show("Đăng nhập thành công");
        }
    }
}
