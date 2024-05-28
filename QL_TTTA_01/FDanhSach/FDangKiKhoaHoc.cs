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
    public partial class FDangKiKhoaHoc : Form
    {
        HocVienDAO HocVienDAO = new HocVienDAO();
        private string maHV;
        public FDangKiKhoaHoc(string maHV)
        {
            this.maHV = maHV;
            InitializeComponent();
        }
        private void LoadDSLH()
        {
            dgvDSLH.DataSource = HocVienDAO.LoadDgvLopDangKy(maHV);
        }
        private void FDangKiMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }
        string maLopHoc;
        private void dgvDSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maLopHoc = dgvDSLH.Rows[e.RowIndex].Cells["maLop"].Value.ToString();
        }
        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index >= 0)
            {
                if (DialogResult.Yes ==
                    MessageBox.Show("Bạn có muốn đăng kí Khóa học " +
                    "[" + dgvDSLH.Rows[e.RowIndex].Cells["tenkhoahoc"].Value.ToString() + "]",
                    "Xác nhận đăng kí", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var rs = HocVienDAO.InsertClassOfStudent(maHV, maLopHoc);
                    if (rs == -1)
                    {
                        MessageBox.Show("Học phần này đã được bạn đăng kí từ trước", "Cảnh báo !!!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí học phần thành công", "Chúc mừng !!!");
                        this.Dispose();
                        return;
                    }
                }
                
            }
        }

       
    }
}
