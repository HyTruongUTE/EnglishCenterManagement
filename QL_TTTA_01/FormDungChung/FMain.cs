using Bunifu.UI.WinForms.BunifuButton;
using QL_TTTA_01.Calendar;
using QL_TTTA_01.Class;
using QL_TTTA_01.FDanhSach;
using QL_TTTA_01.FormDungChung;
using QL_TTTA_01.Message;
using QL_TTTA_01.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TTTA_01
{
    
    public partial class FMain : Form
    {
        AddClass addClass = new AddClass(); 
        string user;
        string loaiTk;
        public enum ButtonName
        {
            btnHomePage,
            btnInformation,
            btnResgisAndScore,
            btnTuition,
            btnSalary,
            btnStudent,
            btnTeacher,
            btnCourseAndClass,
            btnCalendar,
            btnMoney,
            btnNotice
        }
        private void FormUserUse(string checkUser)
        {
            
            AccountType accountType;
            if (!Enum.TryParse(checkUser, true, out accountType))
            {
                return;
            }
            BunifuButton[] buttonsToHide;
            switch (accountType)
            {
                case AccountType.Admin:
                    buttonsToHide = new BunifuButton[] { btnInformation, btnResgisAndScore, btnTuition, btnSalary, btnCalendar };
                    break;
                case AccountType.Teacher:
                    buttonsToHide = new BunifuButton[] { btnResgisAndScore, btnCourseAndClass, btnTuition, btnTeacher, btnMoney };
                    break;
                case AccountType.Student:
                    buttonsToHide = new BunifuButton[] { btnStudent, btnTeacher, btnCourseAndClass, btnMoney, btnSalary };
                    break;
                default:
                    return;
            }
            foreach (BunifuButton button in buttonsToHide)
            {
                button.Hide();
            }
        }
        Bunifu.UI.WinForms.BunifuButton.BunifuButton btnIsClicked = null ;
        Bunifu.UI.WinForms.BunifuButton.BunifuButton lastBtnClicked = null;
        public FMain(string loaiTk , string user)
        {
            InitializeComponent();      
            this.StartPosition = FormStartPosition.CenterScreen;
            addClass.Add_Form(new FHomePage(), pnShowBtn);
            this.user = user;
            this.loaiTk = loaiTk;            
            FormUserUse(loaiTk);                      
        }
        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FLogin flogin = new FLogin();
            flogin.Show();
        }
      
        
        private void Btn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            ButtonName buttonName;
            bool isParsed = Enum.TryParse(btn.Name, out buttonName);
            if (!isParsed)
            {
                return;
            }
            lastBtnClicked = btnIsClicked;
            btnIsClicked = btn;
            switch (buttonName)
            {
                case ButtonName.btnHomePage:
                    addClass.Add_Form(new FHomePage(),pnShowBtn);
                     break;
                case ButtonName.btnInformation:
                    addClass.Add_Form(new FInformation(user),pnShowBtn);
                    break;
                case ButtonName.btnResgisAndScore:
                    addClass.Add_Form(new FTabFormBtn("register", user), pnShowBtn);                 
                    break;
                case ButtonName.btnTuition:
                    addClass.Add_Form(new FTuition(user), pnShowBtn);
                    break;
                case ButtonName.btnSalary:
                    addClass.Add_Form(new FSalary(user), pnShowBtn);
                    break;
                case ButtonName.btnStudent:
                    addClass.Add_Form(new FTabFormBtn("student", user), pnShowBtn);                    
                    break;
                case ButtonName.btnTeacher:
                    addClass.Add_Form(new FTabFormBtn("teacher", user), pnShowBtn);
                    break;
                case ButtonName.btnCourseAndClass:
                    addClass.Add_Form(new FTabFormBtn("course", user), pnShowBtn);
                    break;
                case ButtonName.btnCalendar:
                    addClass.Add_Form(new CalendarForUser(user), pnShowBtn);
                    break;
                case ButtonName.btnMoney:
                    addClass.Add_Form(new FTabFormBtn("money", user), pnShowBtn);
                    break;
                case ButtonName.btnNotice:
                    addClass.Add_Form(new FNotice(loaiTk,user), pnShowBtn);
                    break;
                default:
                    break;
            }
            

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        private void btn_Paint(object sender, PaintEventArgs e)
        {
            if(btnIsClicked != null )
            {
                btnIsClicked.ForeColor = Color.White;
                btnIsClicked.IdleFillColor = Color.FromArgb(116, 180, 254);
            }
            if(lastBtnClicked != null ) 
            {
                lastBtnClicked.OnDisabledState.ForeColor = Color.Black;
                lastBtnClicked.OnDisabledState.FillColor = Color.White;
            }
        }
    }
}
