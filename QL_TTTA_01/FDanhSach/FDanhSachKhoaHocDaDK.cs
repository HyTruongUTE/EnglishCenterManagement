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
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public partial class FDanhSachKhoaHocDaDK : Form
    {
        CheckData checkData = new CheckData();
        HocVienDAO HocVienDAO = new HocVienDAO();
        private string maHV;
        public FDanhSachKhoaHocDaDK(string maHV)
        {
            this.maHV = maHV;
            InitializeComponent();
        }
        private void LoadMonDky()
        {
            dgvMonHocDaDK.DataSource = HocVienDAO.LoadDgvKhoaDaDangKy(maHV);
            checkData.highlightRowsWithSameTimeValues(dgvMonHocDaDK);
        }
        private void FDanhSachMonHocDaDK_Load(object sender, EventArgs e)
        {
            LoadMonDky(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FDangKiKhoaHoc(maHV).ShowDialog();            
            LoadMonDky();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Xác nhận xóa!!!",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = HocVienDAO.DeleteKhoaDaDangKy(maLop, maHV);
                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadMonDky();
                }
                LoadMonDky();
            }
            LoadMonDky();
        }
            string maLop;
       
        private void dgvMonHocDaDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 )
            maLop  = dgvMonHocDaDK.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
        }

        private void dgvMonHocDaDK_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            checkData.highlightRowsWithSameTimeValues(dgvMonHocDaDK);
        }
    }
}
