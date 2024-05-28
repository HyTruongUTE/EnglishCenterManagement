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
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public partial class FKetQuaHocTap : Form
    {
        Calculate calculate = new Calculate();
        HocVienDAO hocVienDAO = new HocVienDAO();
        private string maHocVien;
        public FKetQuaHocTap(string maHocVien)
        {
            InitializeComponent();
            this.maHocVien = maHocVien;
            LoadKetQuaHocTap("");
            txtGPA.Text = calculate.TradeNumber(calculate.DiemTrungBinh(dgvKetQuaHocTap));
        }
        private void LoadKetQuaHocTap(string tukhoa)
        {
            dgvKetQuaHocTap.DataSource = hocVienDAO.LoadLearningOutcomeBy(maHocVien, tukhoa);
        }
        private void FKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKetQuaHocTap("");
        }     
    }
}
