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
    public partial class FBonus : Form
    {
        Calculate calculate = new Calculate();
        GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
        KhoaHocDAO khoaHocDAO = new KhoaHocDAO();
        LopHocDAO lopHocDAO = new LopHocDAO();
        ScoreDAO scoreDAO = new ScoreDAO();
        DataTable DataGiaoVien;
        string user;
        public FBonus()
        {
            InitializeComponent();
            dgvTeacher.DataSource = giaoVienDAO.SearchIdTen(); 
            user = dgvTeacher.Rows[0].Cells["magiaovien"].Value.ToString();
            LoadData(user);
        }
      
        private void LoadData(string giaoVien)
        {
            DataGiaoVien = giaoVienDAO.LoadSalary(giaoVien);
            txtTotalStudent.Text = calculate.SumBy(DataGiaoVien, "siso").ToString();
            txtTotalSalary.Text = calculate.TradeNumber(calculate.SumBy(DataGiaoVien, "tienluong"));
            LoadDgvScore(giaoVien);
            txtGPA.Text = calculate.DiemTrungBinh(dgvStudentScore).ToString("N2");
            txtBonus.Text = giaoVienDAO.LoadThuong(giaoVien);
            lopHocDAO.LoadLop(cbbMaLop);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
        }
        private void LoadDgvScore(string giaoVien)
        {
            dgvStudentScore.DataSource = scoreDAO.LoadScoreTeacher(giaoVien);
            cbbMaLop.DataSource = lopHocDAO.LoadCbbLopForGiaoVien(giaoVien);
            txtTotalClass.Text = cbbMaLop.Items.Count.ToString();
            cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoaForGiaoVien(giaoVien);
        }       
        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string giaoVien = dgvTeacher.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                LoadData(giaoVien);
                this.user = giaoVien;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                if (cbbMaLop.Text == "Class")
                {
                    dgvStudentScore.DataSource = scoreDAO.SearchCbbKhoa(user, cbbMaKhoa.Text);
                    lbGpaOf.Text = "GPA of " +cbbMaKhoa.Text  ;
                }
                else
                {
                    dgvStudentScore.DataSource = scoreDAO.SearchCbbLop(cbbMaLop.Text);
                    lbGpaOf.Text = "GPA of " + cbbMaLop.Text;
                }              
            }
            else
            {
                dgvStudentScore.DataSource = scoreDAO.SearchCbbTukhoa(txtTuKhoa.Text);
                lbGpaOf.Text = "GPA of all student";
            }             
            txtGPA.Text =calculate.DiemTrungBinh(dgvStudentScore).ToString("N2");
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
            lopHocDAO.LoadLop(cbbMaLop);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData(user);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var r = giaoVienDAO.UpdateThuong(user, txtBonus.Text);
            LoadData(user);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ChartGiaoVien chart = new ChartGiaoVien();
            chart.Show();
        }

       
    }
}
