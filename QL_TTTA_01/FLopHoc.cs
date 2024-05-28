using QL_TTTA_01.Calendar;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TTTA_01
{
    public partial class FLopHoc : Form
    {
        private string malophoc;
        private KhoaHocDAO khoaHocDAO =new KhoaHocDAO();
        private GiaoVienDAO giaoVienDAO =new GiaoVienDAO();
        private LopHocDAO LopHocDAO =new LopHocDAO();
        private string maGiaoVien;
        private string selectedValue; 
        public enum Weekday
        {
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
            
        }
        public static int GetWeekdayNumber(string weekday)
        {
            if (Enum.TryParse(weekday, out Weekday result))
            {
                return (int)result;
            }
            else
            {
                return -1; // Trả về -1 nếu chuỗi không hợp lệ
            }
        }

        public static string GetWeekdayName(int weekdayNumber)
        {
            if (Enum.IsDefined(typeof(Weekday), weekdayNumber))
            {
                return Enum.GetName(typeof(Weekday), weekdayNumber);
            }
            else
            {
                return ""; // Trả về chuỗi rỗng nếu số không hợp lệ
            }
        }

        public FLopHoc(string malophoc,string user)
        {
            this.malophoc = malophoc;
            maGiaoVien = user;
            selectedValue = maGiaoVien;
            InitializeComponent();
            dgvTeacher.DataSource = giaoVienDAO.SearchIdTen();
            pnTimeTable.Controls.Clear();
            LoadTimeTable(giaoVienDAO.SearchTimeTable(user));

        }

        private void FLopHoc_Load(object sender, EventArgs e)
        {
            //load data cho 2 cbb
            cbbKhoaHoc.DataSource = khoaHocDAO.LoadCbbKhoa();
            cbbKhoaHoc.DisplayMember = "tenKhoahoc"; 
            cbbKhoaHoc.ValueMember = "maKhoahoc";
            cbbKhoaHoc.SelectedIndex = -1;

            cbbIdTeacher.DataSource = giaoVienDAO.LoadDgvTeacherBy("");
            cbbIdTeacher.DisplayMember = "magiaovien";
            cbbIdTeacher.ValueMember = "magiaovien";
            cbbIdTeacher.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật thông tin lớp học";
                
                var r = LopHocDAO.CatchDataLopHoc(malophoc);  
                cbbIdTeacher.SelectedValue = r["magiaovien"].ToString();
                pnTimeTable.Controls.Clear();
                LoadTimeTable(giaoVienDAO.SearchTimeTable(cbbIdTeacher.Text));
                txtNameTeacher.Text = giaoVienDAO.SelectInFoGiaoVien(cbbIdTeacher.Text)["hoten"].ToString();
                cbbKhoaHoc.SelectedValue = r["makhoahoc"].ToString();
                
                txtThoiGianBatDau.Text = r["thoigianbatdau"].ToString();
                txtThoiGianKetThuc.Text = r["thoigianketthuc"].ToString();
                ccbBuoi1.Text = GetWeekdayName(int.Parse(r["buoi1"].ToString()));
                ccbBuoi2.Text = GetWeekdayName(int.Parse(r["buoi2"].ToString()));
                ccbBuoi3.Text = GetWeekdayName(int.Parse(r["buoi3"].ToString()));

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            
            if (cbbIdTeacher.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên!!!");
                return;
            }
            if (cbbKhoaHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học!!!");
                return;
            }
            List<CustomParameter> lstpara = new List<CustomParameter>();
            var kq = 0;
            lstpara = LopHocDAO.LoadDataLopHoc(cbbIdTeacher.Text, cbbKhoaHoc.SelectedValue.ToString(), cbbIdTeacher.SelectedValue.ToString()
                , txtThoiGianBatDau.Text , txtThoiGianKetThuc.Text, GetWeekdayNumber(ccbBuoi1.Text).ToString() , GetWeekdayNumber(ccbBuoi2.Text).ToString(), GetWeekdayNumber(ccbBuoi3.Text).ToString());
            if (string.IsNullOrEmpty(malophoc))
            {
                 kq = LopHocDAO.InsertLopHoc(lstpara);
            }
            else
            {
                kq = LopHocDAO.UpdateLopHoc(lstpara,malophoc);             
            }
                    
            if (kq == 1)
            {
                if (string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới lớp học thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật lớp thành công.");
                }
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
            this.Dispose();
        }
        private void AddUc( string timeBegin, string timeEnd, string[] buoi)
        {
            UcSetLopItem uc = new UcSetLopItem(timeBegin, timeEnd,buoi);
            uc.Dock = DockStyle.Top;
            pnTimeTable.Controls.Add(uc);
        }
        private void LoadTimeTable(DataTable dt)
        {
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                DataRow dr = dt.Rows[i];
                string[] buoi = new string[] {  dr["buoi1"].ToString(),
                                                    dr["buoi2"].ToString(),
                                                    dr["buoi3"].ToString()};
                //if (i == dt.Rows.Count-1) AddUc(dr["thoigianbatdau"].ToString(), dr["thoigianketthuc"].ToString(), buoi);
                AddUc(dr["thoigianbatdau"].ToString(), dr["thoigianketthuc"].ToString(), buoi);
            }
            if (pnTimeTable.Controls.Count >= 5)
            {
                pnDays.Width = 523;
            }
            else pnDays.Width = 540;
        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbbIdTeacher.Text = dgvTeacher.Rows[e.RowIndex].Cells["maGV"].Value.ToString();
                txtNameTeacher.Text = dgvTeacher.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                pnTimeTable.Controls.Clear();
                LoadTimeTable(giaoVienDAO.SearchTimeTable(cbbIdTeacher.Text));
                
            }
        }

        private void bunifuPanel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel15_Paint(object sender, PaintEventArgs e)
        {
            if(pnTimeTable.Controls.Count >= 5 )
            {
                pnDays.Width = 523;
            }
            else pnDays.Width = 540;


        }
    }
}
