using QL_TTTA_01.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTTA_01.FDanhSach
{
    public partial class FScore : Form
    {
        ScoreDAO scoreDAO = new ScoreDAO();
        KhoaHocDAO khoaHocDAO = new KhoaHocDAO();
        LopHocDAO lopDAO = new LopHocDAO();
        string user;
        public FScore(string user)
        {
            this.user = user;
            InitializeComponent();
            LoadData();
            if (dgvScore.RowCount > 0)
            {
                txtDiemGiuaKi.Text = dgvScore.Rows[0].Cells["diemthigiuaki"].Value.ToString();
                txtDiemCuoiKi.Text = dgvScore.Rows[0].Cells["diemthicuoiki"].Value.ToString();
                maHocVien = dgvScore.Rows[0].Cells["mahoc"].Value.ToString();
                maLopHoc = dgvScore.Rows[0].Cells["malop"].Value.ToString();
            }
            
        }
        private void LoadData()
        {
            
            LoadDgvScore(user);
            lopDAO.LoadLop(cbbMaLop);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);

        }
        private void LoadDgvScore(string user)
        {
            if (!user.Contains("gv"))
            {
                dgvScore.DataSource = scoreDAO.LoadScoreAdmin();
                cbbMaLop.DataSource = lopDAO.LoadCbbLop();
                cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoa();
            }
            else
            {
                dgvScore.DataSource = scoreDAO.LoadScoreTeacher(user);
                cbbMaLop.DataSource = lopDAO.LoadCbbLopForGiaoVien(user);
                cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoaForGiaoVien(user);
            }    
                
        }      
        string maHocVien;
        string maLopHoc;
        private void dgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {        
            if (e.RowIndex >= 0) 
            {
                txtDiemGiuaKi.Text = dgvScore.Rows[e.RowIndex].Cells["diemthigiuaki"].Value.ToString();
                txtDiemCuoiKi.Text = dgvScore.Rows[e.RowIndex].Cells["diemthicuoiki"].Value.ToString();
                maHocVien = dgvScore.Rows[e.RowIndex].Cells["mahoc"].Value.ToString();
                maLopHoc = dgvScore.Rows[e.RowIndex].Cells["malop"].Value.ToString();            
            }          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {         
            int result = scoreDAO.UpdateDiemHocVien(maHocVien,txtDiemGiuaKi.Text,txtDiemCuoiKi.Text,maLopHoc);
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtTuKhoa.Text.Length == 0)
            {
                if (cbbMaLop.Text == "Class")
                {
                    if (cbbMaKhoa.Text == "Course")
                    {
                       LoadData();
                    }
                    else dgvScore.DataSource = scoreDAO.SearchCbbKhoa(user, cbbMaKhoa.Text);
                    
                }
                else
                    dgvScore.DataSource = scoreDAO.SearchCbbLop(cbbMaLop.Text);
            }
            else dgvScore.DataSource = scoreDAO.SearchCbbTukhoa(txtTuKhoa.Text);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
            lopDAO.LoadLop(cbbMaLop);
        }

        private void dgvScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
