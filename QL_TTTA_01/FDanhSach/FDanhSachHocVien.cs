using QL_TTTA_01.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public partial class FDanhSachHocVien : Form
    {
        public static FDanhSachHocVien FFuntionStudentInstance;
        HocVienDAO hocVienDAO = new HocVienDAO();
        LopHocDAO lopDAO = new LopHocDAO();
        KhoaHocDAO khoaHocDAO = new KhoaHocDAO();
        string user; 
        public FDanhSachHocVien(string user)
        {
            InitializeComponent();
            this.user = user;   
        }
        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var maHocVien = dgvStudent.Rows[e.RowIndex].Cells["mahocvien"].Value.ToString();
                new FInfo(maHocVien,"student").ShowDialog();
                dgvStudent.DataSource = hocVienDAO.LoadDgvStudentBy(txtTuKhoa.Text);             
            }
        }      
        private void LoadDgvStudent(string user)
        {
            if (!user.Contains("gv"))
            {
                cbbMaLop.DataSource = lopDAO.LoadCbbLop();
                cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoa();
            }
            else
            {
                cbbMaLop.DataSource = lopDAO.LoadCbbLopForGiaoVien(user);
                cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoaForGiaoVien(user);
            }

        }
        private void FDanhSachHocVien_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = hocVienDAO.LoadDgvStudentBy("");
            LoadDgvStudent(user);
            lopDAO.LoadLop(cbbMaLop);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FInfo(null, "student").ShowDialog(); 
            dgvStudent.DataSource = hocVienDAO.LoadDgvStudentBy("");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                if (cbbMaLop.Text == "Class")
                {
                    dgvStudent.DataSource = hocVienDAO.SearchCbbKhoa(cbbMaKhoa.Text);
                }
                else
                    dgvStudent.DataSource = hocVienDAO.SearchCbbLop(cbbMaLop.Text);
            }
            else dgvStudent.DataSource = hocVienDAO.LoadDgvStudentBy(txtTuKhoa.Text);
            LoadDgvStudent(user);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
            lopDAO.LoadLop(cbbMaLop);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = hocVienDAO.LoadDgvStudentBy("");
        }
        private string maHV;
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            maHV = dgvStudent.Rows[e.RowIndex].Cells["mahocvien"].Value.ToString();          
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = hocVienDAO.DeleteStudent(maHV);
            if (result == 1) 
                dgvStudent.DataSource = hocVienDAO.LoadDgvStudentBy("");           
        }
    }
}
