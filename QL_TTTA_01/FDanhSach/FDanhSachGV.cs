using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public partial class FDanhSachGV : Form
    {
        GiaoVienDAO GiaoVienDAO = new GiaoVienDAO();
        KhoaHocDAO khoaHocDAO=new KhoaHocDAO();
        public FDanhSachGV()
        {
            InitializeComponent();
        }
        private void LoadDSGV()
        {
            dgvTeacher.DataSource = GiaoVienDAO.LoadDgvTeacherBy("");
            cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoa();
        }
        private void LoadKhoa()
        {
            cbbMaKhoa.DisplayMember = "makhoahoc";
            
            cbbMaKhoa.Text = "Course";
        }
        private void FDSGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
        }
        private void dgvTeacher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvTeacher.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new FInfo(mgv,"teacher").ShowDialog();
                LoadDSGV();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FInfo(null,"teacher").ShowDialog(); //neu them moi sv =>msv = null
            LoadDSGV();
        }
        string maGV;
        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            maGV = dgvTeacher.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = GiaoVienDAO.DeleteTeacher(maGV);
            if (result == 1)
                LoadDSGV();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                dgvTeacher.DataSource = GiaoVienDAO.SearchCbbKhoa(cbbMaKhoa.Text);
            }
            else dgvTeacher.DataSource = GiaoVienDAO.LoadDgvTeacherBy(txtTuKhoa.Text);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnShowTab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

}

