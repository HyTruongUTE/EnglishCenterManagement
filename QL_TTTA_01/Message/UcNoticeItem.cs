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
    
    public partial class UcNoticeItem : UserControl
    {
        Notice notice =new Notice();
        string noiDung;
        public string maThongBao;
        public UcNoticeItem(string user , string maNguoiGui, string maThongBao , string ngayGui , string nameGV ,
            string IDLop, string IDKhoa,
            string tieuDe , string noiDung, string seen)
        {
            InitializeComponent();
            txtTieuDe.Text = tieuDe;
            lbMaLop.Text = IDLop;
            lbMaKhoa.Text = IDKhoa;
            lbName.Text = nameGV;
            if(!maNguoiGui.Contains("gv")) lbName.Text = maNguoiGui;
            lbNgayGui.Text = ngayGui;
            this.noiDung = noiDung;
            this.maThongBao = maThongBao;
            if (seen == "1")
            {
                pnInfo.BackgroundColor = Color.SkyBlue;
                txtTieuDe.FillColor = Color.SkyBlue;
                txtTieuDe.BorderColorIdle= Color.SkyBlue;
                txtTieuDe.BorderColorActive= Color.SkyBlue;
                spSeen.Hide();
            }
            if (user.Contains("sv")) btnDelete.Hide();
        }
        public string TextTieuDe
        {
            get { return txtTieuDe.Text; }
        }
        public string TextNoiDung
        {
            get { return noiDung; }
        }
        public string IDLop
        {
            get { return lbMaLop.Text; }
        }
        public string IDKhoa
        {
            get { return lbMaKhoa.Text; }
        }
        public string NameGiaoVien
        {
            get { return lbName.Text; }
        }
        public string NgayGui
        {
            get { return lbNgayGui.Text; }
        }
      
        public event EventHandler btnReadClicked;
        public event EventHandler btnDeleteClicked;

        private void btnRead_Click(object sender, EventArgs e)
        {
            EventHandler handler = btnReadClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = notice.DeleteNotice(maThongBao);
            btnDeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
