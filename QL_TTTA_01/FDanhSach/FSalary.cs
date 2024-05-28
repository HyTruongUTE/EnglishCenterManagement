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
    public partial class FSalary : Form
    {
        GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
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
                sum += float.Parse(dgv.Rows[i].Cells["tienluong"].Value.ToString());
            }
            return sum;
        }
        public FSalary(string user)
        {
            InitializeComponent();
            dgvSalary.DataSource = giaoVienDAO.LoadSalary(user);
            this.user = user;
            txtTotalSalary.Text = TradeMoney(SumSoTien(dgvSalary));
            float bonus = float.Parse(giaoVienDAO.LoadBonus(user).Rows[0]["thuong"].ToString());
            txtBonus.Text =  TradeMoney(float.Parse(giaoVienDAO.LoadThuong(user)));
            txtGrossIncome.Text = TradeMoney(SumSoTien(dgvSalary) + bonus);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
