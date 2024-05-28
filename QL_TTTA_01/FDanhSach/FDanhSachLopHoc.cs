using QL_TTTA_01.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public partial class FDanhSachLopHoc : Form
    {
        CheckData checkData = new CheckData();
        KhoaHocDAO khoaHocDAO = new KhoaHocDAO();
        LopHocDAO lopHocDAO = new LopHocDAO();
        string user;

        public FDanhSachLopHoc(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private string tukhoa;
        private void LoadDSLopHoc()
        {
            dgvLopHoc.DataSource = lopHocDAO.LoadDgvLop("");
            cbbMaKhoa.DataSource = khoaHocDAO.LoadCbbKhoa();
            checkData.highlightRowsWithSameTimeValues(dgvLopHoc);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
        }
        private void FDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLopHoc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FLopHoc(null,user).ShowDialog();
            LoadDSLopHoc();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var malh = dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                var maGv = dgvLopHoc.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new FLopHoc(malh,maGv).ShowDialog();
                LoadDSLopHoc();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != "")
                dgvLopHoc.DataSource = lopHocDAO.LoadDgvLop(txtTuKhoa.Text);
            else dgvLopHoc.DataSource = lopHocDAO.SearchLopHocFormKhoaHoc(cbbMaKhoa.Text);
            khoaHocDAO.LoadKhoa(cbbMaKhoa);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lopHocDAO.DeleteClass(maLop);
            LoadDSLopHoc();
        }
        string maLop;
        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            maLop = dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();   
        }
        private void dgvLopHoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            checkData.highlightRowsWithSameTimeValues(dgvLopHoc);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
