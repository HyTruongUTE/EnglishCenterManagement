using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public partial class FInfo : Form
    {
        HocVienDAO HocVienDAO = new HocVienDAO();
        GiaoVienDAO GiaoVienDAO = new GiaoVienDAO();
        public FInfo(string mess,string ObjectIsChoose )
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.mess = mess;
            this.objectIsChoose =ObjectIsChoose;
            InitializeComponent();
            if (ObjectIsChoose == "student")
                pnLevelTeacher.Visible = false;
            
        }
        private string objectIsChoose;
        private string mess;
        public FInfo()
        {
            InitializeComponent();
        }
        private void FInfo_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mess))
            {
                lbTitle.Text = "_______ADD NEW " + objectIsChoose.ToUpper()+"_______";               
            }
            else
            {
                lbTitle.Text = "UPDATE INFOMATION " + objectIsChoose.ToUpper();
                var r = new DataBase().Select("SelectHocVien '" + mess + "'");        
                if ( objectIsChoose == "teacher")
                {
                    r = new DataBase().Select("SelectGiaoVien '" + mess + "'");
                    txtToeic.Text = r["toeic"].ToString();
                    txtIelts.Text = r["ielts"].ToString();
                }
                    
                txtFirstName.Text = r["ho"].ToString();
                txtMiddleName.Text = r["tendem"].ToString();
                txtName.Text = r["ten"].ToString();
                mtxtNgaySinh.Text = r["ngsinh"].ToString();
                if (r["gioitinh"].ToString() == "Nam")
                {
                    bunifuRbtMale.Checked = true;
                    bunifuRbtFemale.Checked = false;
                }
                else
                {
                    bunifuRbtMale.Checked = false;
                    bunifuRbtFemale.Checked = true;
                }
                txtAddress.Text = r["diachi"].ToString();
                txtPhoneNumber.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void bunifuBtSave_Click(object sender, EventArgs e)
        {
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtxtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!!!");
                mtxtNgaySinh.Select();
                return;
            }
            string gioitinh = bunifuRbtMale.Checked ? "1" : "0";
            List<CustomParameter> lstpara = new List<CustomParameter>();
            
            if (objectIsChoose == "student")
            lstpara = HocVienDAO.LoadDataStudent(txtFirstName.Text, txtMiddleName.Text, txtName.Text, 
                ngaysinh, gioitinh, txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text);
            else if (objectIsChoose == "teacher") lstpara = GiaoVienDAO.LoadDataTeacher(txtFirstName.Text, txtMiddleName.Text, txtName.Text,
                ngaysinh, gioitinh, txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text,txtToeic.Text,txtIelts.Text);

            var rs = 0;

            if (objectIsChoose == "student")
            {
                if (string.IsNullOrEmpty(mess)) 
                    rs = HocVienDAO.InsertStudent(lstpara);
                else 
                    rs = HocVienDAO.UpdateStudent(mess, lstpara);
            }
            else if (objectIsChoose =="teacher")
            {
                if (string.IsNullOrEmpty(mess))
                    rs = GiaoVienDAO.InsertTeacher(lstpara);
                else
                    rs = GiaoVienDAO.UpdateTeacher(mess, lstpara);
            }              
            if (rs == 1)
            {
                MessageBox.Show("Lưu thành công. ");
                this.Dispose();
            }
            else 
            {
                MessageBox.Show("Thực thi thất bại!!!");
            }
        }




   


    }
}
