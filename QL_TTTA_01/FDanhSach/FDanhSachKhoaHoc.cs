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
    public partial class FDanhSachKhoaHoc : Form
    {
        KhoaHocDAO khoaHocDAO = new KhoaHocDAO();
        string user;
        public FDanhSachKhoaHoc(string user )
        {
            InitializeComponent();
            this.user = user;   
        }
        private string tukhoa = "";
        private void LoadDSKhoaHoc()
        {
            dgvKhoaHoc.DataSource = khoaHocDAO.LoadDgvKhoaHoc("");
        }
        private void FDanhSachMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSKhoaHoc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FKhoaHoc(null,user).ShowDialog();
            LoadDSKhoaHoc();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvKhoaHoc.DataSource = khoaHocDAO.LoadDgvKhoaHoc(txtTuKhoa.Text);
        }

        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var maKhoaHoc = dgvKhoaHoc.Rows[e.RowIndex].Cells["makh"].Value.ToString();                
                new FKhoaHoc(maKhoaHoc,user).ShowDialog();
                LoadDSKhoaHoc();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = khoaHocDAO.DeleteKhoaHoc(maKhoaHoc);
             LoadDSKhoaHoc();

        }
        string maKhoaHoc;
        private void dgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            maKhoaHoc = dgvKhoaHoc.Rows[e.RowIndex].Cells["makh"].Value.ToString();
        }
    }
}
