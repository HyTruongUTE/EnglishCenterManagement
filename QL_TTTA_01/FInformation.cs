using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuDataGridView.Transitions;

namespace QL_TTTA_01
{
    public partial class FInformation : Form
    {
        HocVienDAO hocVienDAO = new HocVienDAO();
        GiaoVienDAO giaoVienDAO = new GiaoVienDAO();

        private void HienThiInfo(DataRow row)
        {

            txtName.Text = txtNameCard.Text = row["hoten"].ToString();
            txtBirthDay.Text = txtBirthDayCard.Text = row["ngsinh"].ToString();
            if (row["gioitinh"].ToString() == "Nam")
            {
                bunifuRbtMale.Checked = true;
                bunifuRbtFemale.Checked = false ;
                txtSex.Text= txtSexCard.Text = "Nam";
            }
            else
            {
                bunifuRbtFemale.Checked = true;
                bunifuRbtMale.Checked = false;
                txtSex.Text = txtSexCard.Text = "Nữ";
            }
            txtAddress.Text = row["diachi"].ToString();
            txtEmail.Text = row["email"].ToString();
            txtPhoneNumber.Text = row["dienthoai"].ToString();
            txtTimeBegin.Text = "Begin:   " + row["ngaytao"].ToString();
            txtTimeBeginCard.Text = row["ngaytao"].ToString();
            txtTimeUpdate.Text = "Update: " + row["ngaycapnhat"].ToString();
        }
        public FInformation(string user)
        {
            InitializeComponent();
            txtID.Text = txtIDCard.Text = user;
            if (user.Contains("sv"))
            {
                pnLevelTeacher.Hide();
                DataRow row = hocVienDAO.SelectInFoHocVien(user);
                HienThiInfo(row);
            }
            else
            {
                DataRow row = giaoVienDAO.SelectInFoGiaoVien(user);
                HienThiInfo(row);
                txtToeic.Text = row["toeic"].ToString();
                txtIelts.Text = row["ielts"].ToString();
                lbNameCard.Text = "TEACHER CARD";
            }
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
