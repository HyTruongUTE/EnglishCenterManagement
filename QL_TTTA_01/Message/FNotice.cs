using Bunifu.UI.WinForms.BunifuButton;
using QL_TTTA_01.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TTTA_01.Message
{
    public partial class FNotice : Form
    {
        Notice notice = new Notice();
        LopHocDAO lopDAO = new LopHocDAO();
        string user ="admin";
        string seen;
        DataTable dt;
        AccountType accountType;
        public FNotice(string loaiTk,string user)
        {          
            if (!Enum.TryParse(loaiTk, true, out accountType))
            {
                return;
            }
            InitializeComponent();
            this.user = user;
            LoadNotice(user);
            cbbMaLop.DisplayMember = cbbMaLopSearch.DisplayMember = "malophoc";
            cbbMaLopSearch.Text = "All";
        }
        private void LoadBy(AccountType userType)
        {
            DataTable dataCbb = new DataTable();
            switch (userType)
            {
               
                case AccountType.Admin:
                    this.dt = notice.SelectNoticeByAdmin();
                    dataCbb = lopDAO.LoadCbbLopForAdmin();
                    seen = "adminseen";
                    cbbMaLop.DataSource = lopDAO.LoadCbbLopForAdmin();
                    break;
                case AccountType.Teacher:
                    this.dt = notice.SelectNoticeByGiaoVien(user);
                    dataCbb = lopDAO.LoadCbbLopForGiaoVien(user);
                    seen = "giaovienseen";
                    cbbMaLop.DataSource  = lopDAO.LoadCbbLopForGiaoVien(user);
                    break;
                case AccountType.Student:
                    this.dt = notice.SelectNoticeByHocVien(user);
                    dataCbb = lopDAO.LoadCbbLopForHocVien(user);
                    seen = "hocvienseen";
                    btnSend.Hide();
                    cbbMaLop.DataSource = lopDAO.LoadCbbLopForHocVien(user);                     
                    break;
                default: 
                    
                    break;

            }
            dataCbb.Rows.Add("All");
            cbbMaLopSearch.DataSource = dataCbb;
            
        }
        public void LoadNotice(string agent )
        {
            pnNotice.Controls.Clear();
            if( agent != user ) 
            {
                this.dt = notice.SelectNoticeByLop(agent);
            }
            else LoadBy(accountType);
            UcNoticeItem[] ucNoticeItems = new UcNoticeItem[dt.Rows.Count];
            
            for ( int i = 0;  i < dt.Rows.Count; i++ ) 
            { 
                ucNoticeItems[i] = new UcNoticeItem(user ,dt.Rows[i]["maNguoiGui"].ToString(),
                                                    dt.Rows[i]["mathongbao"].ToString(),dt.Rows[i]["ngaygui"].ToString(), 
                                                    dt.Rows[i]["hoten"].ToString(), dt.Rows[i]["malophoc"].ToString(),
                                                    dt.Rows[i]["makhoahoc"].ToString(),
                                                    dt.Rows[i]["tieude"].ToString(), dt.Rows[i]["noidung"].ToString(),
                                                    dt.Rows[i][seen].ToString());
                ucNoticeItems[i].Dock = DockStyle.Top;
                pnNotice.Controls.Add(ucNoticeItems[i]);                
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ucNoticeItems[i].btnReadClicked += myUserControl_btnReadClicked;
                ucNoticeItems[i].btnDeleteClicked += myUserControl_btnDeleteClicked;
            }
            

        }
        private void myUserControl_btnReadClicked(object sender, EventArgs e)
        {
            UcNoticeItem myUserControl = sender as UcNoticeItem;
            txtTieuDe.Text = myUserControl.TextTieuDe;
            txtNoiDung.Text = myUserControl.TextNoiDung;
            lbName.Text = myUserControl.NameGiaoVien;
            cbbMaLop.Text = myUserControl.IDLop;
            lbNgayGui.Text = myUserControl.NgayGui;
            if (user == "admin")
                notice.UpdateSeenThongBaoByAdmin(myUserControl.maThongBao);
            else notice.UpdateSeenByGiaoVienOrHocVien(myUserControl.maThongBao, user);
            LoadNotice(user);

        }
        private void myUserControl_btnDeleteClicked(object sender, EventArgs e)
        {
            LoadNotice(user);
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if(!user.Contains("sv")) notice.InsertNotice(user, cbbMaLop.Text, txtTieuDe.Text, txtNoiDung.Text);
            LoadNotice(user);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbbMaLopSearch.Text == "All")
                LoadNotice(user);
            else LoadNotice(cbbMaLopSearch.Text);
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
