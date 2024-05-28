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
    public partial class FKhoaHoc : Form
    {
        private KhoaHocDAO khoaHocDAO = new KhoaHocDAO();
        private string makh;
        private string nguoithuchien;
        public FKhoaHoc(string makh, string user)
        {
            this.makh = makh;
            nguoithuchien = user;
            InitializeComponent();
        }

        private void FMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(makh))
            {
                this.Text = "Thêm mới Khóa học";
            }
            else
            {
                this.Text = "Cập nhật thông tin Khóa học";
                var r = khoaHocDAO.CatchKhoaHoc(makh);
                txtKhoaHoc.Text = r["tenkhoahoc"].ToString();
                txtSoTien.Text = r["sotien"].ToString();
                txtMaKhoa.Text = makh;
            }
        }
     
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            List<CustomParameter> lstpara = new List<CustomParameter>();
            var kq = 0;
            lstpara = khoaHocDAO.LoadDataKhoaHoc(nguoithuchien, txtMaKhoa.Text, txtKhoaHoc.Text,txtSoTien.Text);
            if (string.IsNullOrEmpty(makh))
            {
                kq = khoaHocDAO.InsertKhoaHoc(lstpara);
            }
            else
            {
                kq = khoaHocDAO.UpdateKhoaHoc(lstpara, makh);
            }

            if (kq == 1)
            {
                if (string.IsNullOrEmpty(makh))
                {
                    MessageBox.Show("Thêm mới khóa học thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật khóa thành công.");
                }
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
            this.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
