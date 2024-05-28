using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTTA_01.Class
{
    public class Calculate
    {
        public float DiemTrungBinh(Bunifu.UI.WinForms.BunifuDataGridView dgv)
        {
            float sum = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                sum += float.Parse(dgv.Rows[i].Cells["dtb"].Value.ToString());
            }
            return sum / dgv.RowCount;
        }
        public string TradeNumber(float number)
        {
            return number.ToString("N", CultureInfo.CreateSpecificCulture("en-US")) + " đ";
        }
        public float SumBy(DataTable dataTable, string cellName)
        {
            float sum = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                sum += float.Parse(dataTable.Rows[i][cellName].ToString());
            }
            return sum;
        }
    }
}
