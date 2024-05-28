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
    public partial class CalendarForUser : Form
    {
        HocVienDAO HocVienDAO = new HocVienDAO();
        GiaoVienDAO GiaoVienDAO = new GiaoVienDAO();
        string user;
        private void  AddUc(string maKhoa, string timeBegin, string timeEnd, string nameTeacher,Panel panel)
        {
            UcTimeTableItem uc = new UcTimeTableItem(maKhoa, timeBegin, timeEnd, nameTeacher);
            uc.Dock = DockStyle.Top;
            panel.Controls.Add(uc);
        }
        private void LoadTimeTable(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string[] buoi = new string[] {  dr["buoi1"].ToString(),
                                                    dr["buoi2"].ToString(),
                                                    dr["buoi3"].ToString()};
                for (int j = 0; j < 3; j++)
                {
                    switch (buoi[j])
                    {
                        case "2":
                            AddUc(dr["makhoahoc"].ToString(), dr["thoigianbatdau"].ToString(),
                            dr["thoigianketthuc"].ToString(), dr["hoten"].ToString(), pnThu2_Items);
                            break;
                        case "3":
                            AddUc(dr["makhoahoc"].ToString(), dr["thoigianbatdau"].ToString(),
                            dr["thoigianketthuc"].ToString(), dr["hoten"].ToString(), pnThu3_Items);
                            break;
                        case "4":
                            AddUc(dr["makhoahoc"].ToString(), dr["thoigianbatdau"].ToString(),
                            dr["thoigianketthuc"].ToString(), dr["hoten"].ToString(), pnThu4_Items);
                            break;
                        case "5":
                            AddUc(dr["makhoahoc"].ToString(), dr["thoigianbatdau"].ToString(),
                            dr["thoigianketthuc"].ToString(), dr["hoten"].ToString(), pnThu5_Items);
                            break;
                        case "6":
                            AddUc(dr["makhoahoc"].ToString(), dr["thoigianbatdau"].ToString(),
                            dr["thoigianketthuc"].ToString(), dr["hoten"].ToString(), pnThu6_Items);
                            break;
                        case "7":
                            AddUc(dr["makhoahoc"].ToString(), dr["thoigianbatdau"].ToString(),
                            dr["thoigianketthuc"].ToString(), dr["hoten"].ToString(), pnThu7_Items);
                            break;
                    }
                }
            }

        }
        private DataTable GetDataTable(string user)
        {
            if (user.Contains("sv"))
            {
                var r = HocVienDAO.SelectNoteHocVien(user);
                txtNotes.Text = r["note"].ToString();
                return HocVienDAO.SearchTimeTable(user);
                
            }
            else
            if (user.Contains("gv"))
            {
                var r = GiaoVienDAO.SelectNoteGiaoVien(user);
                txtNotes.Text = r["note"].ToString();
                return  GiaoVienDAO.SearchTimeTable(user);
            }
            return new DataTable();
        }
        public CalendarForUser(string user)
        {
            InitializeComponent();          
            this.user = user;
            LoadTimeTable(GetDataTable(user));   
            
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.Contains("sv"))
            {
                int excute = HocVienDAO.UpdateNote(user, txtNotes.Text);
            }
            else
            if (user.Contains("gv"))
            {
                int excute = GiaoVienDAO.UpdateNote(user, txtNotes.Text);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
