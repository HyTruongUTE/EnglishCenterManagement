using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTTA_01.Calendar
{
    public partial class UcTimeTableItem : UserControl
    {
        public UcTimeTableItem(string maKhoa , string timeBegin ,string timeEnd , string nameTeacher )
        {
            InitializeComponent();
            txtMaKhoa.Text = maKhoa;
            float tBegin = float.Parse(timeBegin);
            float tEnd = float.Parse(timeEnd);
            lbTimeBegin.Text = tBegin.ToString("F2");   
            lbTimeEnd.Text = tEnd.ToString("F2");
            if (nameTeacher.Contains("A1"))
            {
                txtNameTeacher.Text ="Class: " +nameTeacher;
            }
            else
            txtNameTeacher.Text = "Teacher: "+nameTeacher;
        }

        private void lbTimeBegin_Click(object sender, EventArgs e)
        {

        }
    }
}
