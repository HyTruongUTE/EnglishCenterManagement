using Bunifu.Charts.WinForms.ChartTypes;
using Bunifu.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TTTA_01.Class;
using Newtonsoft.Json.Linq;

namespace QL_TTTA_01
{
    public partial class ChartGiaoVien : Form
    {
        ScoreDAO scoreDAO = new ScoreDAO();
        public ChartGiaoVien()
        {
            InitializeComponent();
            
        }
        private void LoadChart()
        {
            DataTable dt = new DataTable();
            dt = scoreDAO.LoadScoreChartTeacher(txtNumMin.Text, txtNumMax.Text);
            List<Color> bgColors = new List<Color>();
            var r = new Random();
            List<string> labels = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                labels.Add(row["hoten"].ToString());
            }
            bunifuChartCanvas1.Labels = labels.ToArray();
            // Add data to the chart
            foreach (DataRow row in dt.Rows)
            {
                int value = Convert.ToInt32(row["sohocvien"]);
                DoughnutChartGiaoVien.Data.Add(value);
                bgColors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
                DoughnutChartGiaoVien.BackgroundColor.Add(bgColors.Last());
            }
        }
        private void LoadData()
        {
            
            LoadChart();
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DoughnutChartGiaoVien.Data.Clear();         
        }
        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}