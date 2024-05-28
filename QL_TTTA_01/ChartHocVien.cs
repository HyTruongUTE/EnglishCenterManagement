using QL_TTTA_01.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_TTTA_01
{
    public partial class ChartHocVien : Form
    {
        ScoreDAO scoreDAO =new ScoreDAO();
        KhoaHocDAO khoaHocDAO = new KhoaHocDAO();

        public ChartHocVien()
        {
            InitializeComponent();
            LoadCbb();
        }
        private void LoadCbb()
        {
            DataTable dataCbb = new DataTable();
            dataCbb = khoaHocDAO.LoadCbbKhoa();
            DataRow dr = dataCbb.NewRow();
            dr["makhoahoc"] = "ALL";
            dataCbb.Rows.InsertAt(dr, 0);
            cbbMaKhoa.DisplayMember = "makhoahoc";
            cbbMaKhoa.DataSource = dataCbb;
            cbbMaKhoa.Text = "All";
        }
        private void LoadChart(DataTable dt)
        {
            foreach (var series in ChartDiemSo.Series)
            {
                series.Points.Clear();
            }
            ChartDiemSo.Series["Số lượng học sinh đạt được"].Points.AddXY("0 - 3", Convert.ToInt32(dt.Rows[0]["SoLuongHocVien"]));
            ChartDiemSo.Series["Số lượng học sinh đạt được"].Points.AddXY("3 - 5", Convert.ToInt32(dt.Rows[1]["SoLuongHocVien"]));
            ChartDiemSo.Series["Số lượng học sinh đạt được"].Points.AddXY("5 - 7", Convert.ToInt32(dt.Rows[2]["SoLuongHocVien"]));
            ChartDiemSo.Series["Số lượng học sinh đạt được"].Points.AddXY("7 - 8", Convert.ToInt32(dt.Rows[3]["SoLuongHocVien"]));
            ChartDiemSo.Series["Số lượng học sinh đạt được"].Points.AddXY("8 - 9", Convert.ToInt32(dt.Rows[4]["SoLuongHocVien"]));
            ChartDiemSo.Series["Số lượng học sinh đạt được"].Points.AddXY("9 - 10", Convert.ToInt32(dt.Rows[5]["SoLuongHocVien"]));
        }

        private void ChartHocVien_Load(object sender, EventArgs e)
        { 
            LoadChart(scoreDAO.LoadScoreChart());
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            this.Hide();        
        }

        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbMaKhoa.SelectedIndex > 0) 
            {
                LoadChart(scoreDAO.LoadScoreChartByKhoa(cbbMaKhoa.Text));
            }
            else LoadChart(scoreDAO.LoadScoreChart());

        }
    }
}
