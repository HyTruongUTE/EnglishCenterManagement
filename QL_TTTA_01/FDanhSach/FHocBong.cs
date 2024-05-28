using QL_TTTA_01.Class;
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

namespace QL_TTTA_01.FDanhSach
{
    public partial class FHocBong : Form
    {
        Calculate calculate =new Calculate();
        HocVienDAO HocVienDAO = new HocVienDAO();
        LopHocDAO lopDAO = new LopHocDAO();
        KhoaHocDAO khoaHocDAO = new KhoaHocDAO();
        ScoreDAO scoreDAO = new ScoreDAO();
        string maHocVien;
        public FHocBong(string user)
        {
            InitializeComponent();
            LoadDgvScore();
            maHocVien = dgvStudent.Rows[0].Cells["mahocV"].Value.ToString();
            LoadKetQuaHocTap("");
        }
        private void LoadKetQuaHocTap(string tukhoa)
        {
            dgvKetQuaHocTap.DataSource = HocVienDAO.LoadLearningOutcomeBy(maHocVien, tukhoa);
            txtGPA.Text = calculate.TradeNumber(calculate.DiemTrungBinh(dgvKetQuaHocTap));
            txtIDStudent.Text = maHocVien;
            txtScholarship.Text = HocVienDAO.LoadScholarship(maHocVien).Rows[0]["hocbong"].ToString();
        }     
        private void LoadKhoa()
        {
            cbbMaKhoa.DisplayMember = "makhoahoc";
            
            cbbMaKhoa.Text = "Course";
        }
        private void LoadDgvScore()
        {
            dgvStudent.DataSource = HocVienDAO.LoadDgvStudentBy("");
            cbbMaLop.DataSource = lopDAO.LoadCbbLop();
            cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoa();
            lopDAO.LoadLop(cbbMaLop);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                if (cbbMaLop.Text == "Class")
                {
                    dgvStudent.DataSource = HocVienDAO.SearchCbbKhoa(cbbMaKhoa.Text);
                }
                else
                    dgvStudent.DataSource = HocVienDAO.SearchCbbLop(cbbMaLop.Text);
            }
            else dgvStudent.DataSource = HocVienDAO.LoadDgvStudentBy(txtTuKhoa.Text);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
            lopDAO.LoadLop(cbbMaLop);
        }
        
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maHocVien = dgvStudent.Rows[e.RowIndex].Cells["mahocV"].Value.ToString();
                LoadKetQuaHocTap("");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = HocVienDAO.UpdateScholarship(maHocVien, txtScholarship.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDgvScore();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ChartHocVien chart = new ChartHocVien();
            chart.Show();
        }
    }
}
