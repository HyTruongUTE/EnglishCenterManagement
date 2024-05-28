using QL_TTTA_01.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    enum AccountType
    {
        Admin,
        Teacher,
        Student
    }
    

    public partial class FLogin : Form
    {
        AccountCheck accountCheck = new AccountCheck();

        public FLogin()
        {
            InitializeComponent();
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string userName="";
        public string loaiTK ="";

        private bool IsTextNull()
        {
            if (cbbAccount.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return true;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
                txtUserName.Select();
                return true;
            }
            if (string.IsNullOrEmpty(txtPasswork.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return true;
            }
            return false;
        }
        private bool TryLogin()
        {
            List<CustomParameter> lstpara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                    key ="@loaitaikhoan",
                    value=loaiTK
                    },
                    new CustomParameter()
                    {
                    key ="@taikhoan",
                    value=txtUserName.Text
                    },
                    new CustomParameter()
                    {
                    key ="@matkhau",
                    value=txtPasswork.Text
                    }
                };
            var rs = new DataBase().SelectData("DangNhap", lstpara);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                return true;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                return false;
            }
            
        }
        public bool CheckAccount()
        {        
            if (IsTextNull()) return false;
            loaiTK = accountCheck.TypeAccount(cbbAccount.Text);
            return TryLogin();          
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckAccount())
            {
                var f = new FMain(loaiTK, txtUserName.Text);
                f.Show();
            }          
        }  
        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch1.Checked) txtPasswork.PasswordChar = '\0';
            else txtPasswork.PasswordChar = '\u25CF';
           
        }

    }
}
