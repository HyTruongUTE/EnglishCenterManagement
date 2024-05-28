using QL_TTTA_01.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTTA_01
{
    public partial class UcSetLopItem : UserControl
    {
        Calculate calculate =new Calculate();
        private string TradeTime(string timeBegin, string timeEnd)
        {
            return float.Parse(timeBegin).ToString("00.00") + "-"+ float.Parse(timeEnd).ToString("00.00");
        }

        public UcSetLopItem(string timeBegin, string timeEnd, string[] buoi)
        {
            InitializeComponent();
            for (int j = 0; j < 3; j++)
            {
                switch (buoi[j])
                {
                    case "2":
                        lbTimeTh2.Text = TradeTime(timeBegin, timeEnd);
                        break;
                    case "3":
                        lbTimeTh3.Text = TradeTime(timeBegin, timeEnd);
                        break;
                    case "4":
                        lbTimeTh4.Text = TradeTime(timeBegin, timeEnd);
                        break;
                    case "5":
                        lbTimeTh5.Text = TradeTime(timeBegin, timeEnd);
                        break;
                    case "6":
                        lbTimeTh6.Text = TradeTime(timeBegin, timeEnd);
                        break;
                    case "7":
                        lbTimeTh7.Text = TradeTime(timeBegin, timeEnd);
                        break;
                }
            }
        }
    }
}
