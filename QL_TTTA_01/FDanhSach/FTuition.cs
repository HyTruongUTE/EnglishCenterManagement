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
    public partial class FTuition : Form
    {
        HocVienDAO hocVienDAO = new HocVienDAO();
        string user;
        private string TradeMoney(float money)
        {         
            return money.ToString("N", CultureInfo.CreateSpecificCulture("en-US")) + " Đ";
        }
        private float SumSoTien(Bunifu.UI.WinForms.BunifuDataGridView dgv)
        {
            float sum = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                sum += float.Parse(dgv.Rows[i].Cells["sotien"].Value.ToString());
            }
            return sum;
        }
        public FTuition(string user)
        {
            InitializeComponent();
            dgvTuition.DataSource = hocVienDAO.LoadTuition(user); 
            this.user = user;           
            txtTotalTuition.Text = TradeMoney(SumSoTien(dgvTuition));
            float scholarship = float.Parse(hocVienDAO.LoadScholarship(user).Rows[0]["hocbong"].ToString());
            txtScholarship.Text = TradeMoney(scholarship);
            txtTotalPay.Text = TradeMoney(SumSoTien(dgvTuition)- scholarship);
        }

        private void txtTotalTuition_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
