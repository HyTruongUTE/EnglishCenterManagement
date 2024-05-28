using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTTA_01.Class
{
    public class CheckData
    {
        private bool IsNotNull(int i, string s, Bunifu.UI.WinForms.BunifuDataGridView dgv)
        {
            if (dgv.Rows[i].Cells[s].Value != null) return true; return false;
        }
        private bool IsSameTime(int i, int j,Bunifu.UI.WinForms.BunifuDataGridView dgv)
        {
            float thoiGianBatDauJ = 0;
            float thoiGianKetThucJ = 0;
            float thoiGianBatDauI = 0;
            float thoiGianKetThucI = 0;
            if (dgv.Rows[i].Cells["thoigianbatdau"].Value != null)
                thoiGianBatDauI = float.Parse(dgv.Rows[i].Cells["thoigianbatdau"].Value.ToString());
            if (dgv.Rows[i].Cells["thoigianketthuc"].Value != null)
                thoiGianKetThucI = float.Parse(dgv.Rows[i].Cells["thoigianketthuc"].Value.ToString());
            if (dgv.Rows[j].Cells["thoigianbatdau"].Value != null)
                thoiGianBatDauJ = float.Parse(dgv.Rows[j].Cells["thoigianbatdau"].Value.ToString());
            if (dgv.Rows[j].Cells["thoigianketthuc"].Value != null)
                thoiGianKetThucJ = float.Parse(dgv.Rows[j].Cells["thoigianketthuc"].Value.ToString());
            if (IsNotNull(j, "buoi1",dgv) && IsNotNull(j, "buoi2", dgv) && IsNotNull(j, "buoi3", dgv) && IsNotNull(i, "buoi1", dgv) && IsNotNull(i, "buoi2", dgv) && IsNotNull(i, "buoi3", dgv))
            {
                string[] buoiCuaHangI = new string[] { dgv.Rows[i].Cells["buoi1"].Value.ToString(),
                                             dgv.Rows[i].Cells["buoi2"].Value.ToString(),
                                             dgv.Rows[i].Cells["buoi3"].Value.ToString()};
                string[] buoiCuaHangJ = new string[] { dgv.Rows[j].Cells["buoi1"].Value.ToString(),
                                             dgv.Rows[j].Cells["buoi2"].Value.ToString(),
                                             dgv.Rows[j].Cells["buoi3"].Value.ToString()};

                for (int iCheck = 0; iCheck < 3; iCheck++)
                    for (int jCheck = 0; jCheck < 3; jCheck++)
                        if (buoiCuaHangI[iCheck] == buoiCuaHangJ[jCheck])
                        {
                            if (thoiGianBatDauI >= thoiGianBatDauJ && thoiGianBatDauI < thoiGianKetThucJ)
                                return true;
                            if (thoiGianKetThucI > thoiGianBatDauJ && thoiGianKetThucI <= thoiGianKetThucJ)
                                return true;
                            if (thoiGianBatDauJ >= thoiGianBatDauI && thoiGianBatDauJ < thoiGianKetThucI)
                                return true;
                            if (thoiGianKetThucJ > thoiGianBatDauI && thoiGianKetThucJ <= thoiGianKetThucI)
                                return true;
                        }
            }
            return false;
        }
        private bool hasMaGiaoVien(Bunifu.UI.WinForms.BunifuDataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Name == "magiaovien")
                {
                    return true;
                }
            }
            return false;
        }
        public void highlightRowsWithSameTimeValues(Bunifu.UI.WinForms.BunifuDataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = i + 1; j < dgv.Rows.Count; j++)
                {
                    if (IsSameTime(i, j,dgv))
                    {
                        if (!hasMaGiaoVien(dgv) || dgv.Rows[i].Cells["magiaovien"].Value.ToString() == dgv.Rows[j].Cells["magiaovien"].Value.ToString())
                        {
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            dgv.Rows[j].DefaultCellStyle.BackColor = Color.Red;
                        }                        
                    }
                }
            }
        }
    }
}
