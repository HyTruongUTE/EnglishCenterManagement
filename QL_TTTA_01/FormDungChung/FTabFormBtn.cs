
using QL_TTTA_01.Class;
using QL_TTTA_01.FDanhSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTTA_01.NhanVien
{
    public partial class FTabFormBtn : Form
    {
        AddClass addClass = new AddClass();
        string btnIsClicked = "";
        string account = "";
        public FTabFormBtn(string btnNameIsClick, string account)
        {
            InitializeComponent();
            btnIsClicked = btnNameIsClick;
            this.account = account;
            switch (btnIsClicked)
            {
                case "student":
                    addClass.Add_Form(new FDanhSachHocVien(account),pnShowTab);
                    btnTab_1.Text = "Student List";
                    btnTab_2.Text = "Score";
                    break;
                case "teacher":
                    addClass.Add_Form(new FDanhSachGV(), pnShowTab);
                    btnTab_1.Text = "Teacher List";
                    btnTab_2.Hide();
                    break;
                case "course":
                    addClass.Add_Form(new FDanhSachKhoaHoc(account), pnShowTab);
                    btnTab_1.Text = "Course List";
                    btnTab_2.Text = "Class List";
                    break;
                case "money":
                    addClass.Add_Form(new FHocBong(account), pnShowTab);
                    btnTab_1.Text = "Scholarship";
                    btnTab_2.Text = "Bonus";
                    break;
                case "register":
                    addClass.Add_Form(new FDanhSachKhoaHocDaDK(account), pnShowTab);
                    btnTab_1.Text = "Register course";
                    btnTab_2.Text = "Learning outcomes";
                    break;
                default:
                    break;
            }
            pnTab_1.BackColor = Color.FromArgb(116, 180, 254);
            btnIsClicked = btnNameIsClick;
        }
        
        private void Btn_Click(object sender,EventArgs e)
        {
            foreach(var pn in tableTabForm.Controls.OfType<Panel>())
            {
                pn.BackColor = Color.White;
            }
            Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            switch (btn.Name) 
            {
                case "btnTab_1":
                    switch (btnIsClicked)
                    {
                        case "teacher":
                            addClass.Add_Form(new FDanhSachGV(), pnShowTab);
                            break;
                        case "register":
                            addClass.Add_Form(new FDanhSachKhoaHocDaDK(account), pnShowTab);
                            break;
                        case "course":
                            addClass.Add_Form(new FDanhSachKhoaHoc(account), pnShowTab);
                            break;
                        case "student":
                            addClass.Add_Form(new FDanhSachHocVien(account), pnShowTab);
                            break;
                        case "money":
                            addClass.Add_Form(new FHocBong(account), pnShowTab);
                            break;
                    }
                    pnTab_1.BackColor=Color.FromArgb(116, 180, 254);
                    break;
                case "btnTab_2":
                    switch (btnIsClicked)
                    {
                        case "register":
                            addClass.Add_Form(new FKetQuaHocTap(account), pnShowTab);
                            break;
                        case "course":
                            addClass.Add_Form(new FDanhSachLopHoc(account), pnShowTab);
                            break;
                        case "student":
                            addClass.Add_Form(new FScore(account), pnShowTab);
                            break;
                        case "money":
                            addClass.Add_Form(new FBonus(), pnShowTab);
                            break;
                    }
                    pnTab_2.BackColor = Color.FromArgb(116, 180, 254);
                    break;               
                default:
                    addClass.Add_Form(new FDanhSachHocVien(account), pnShowTab);
                    break;
            }   
        }
    }
}
