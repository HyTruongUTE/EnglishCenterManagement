using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTTA_01.Class
{
    public class AddClass
    {
        public void Add_Form(Form nameForm,Panel pnToAdd)
        {
            pnToAdd.Controls.Clear();
            nameForm.Dock = DockStyle.Fill;
            nameForm.FormBorderStyle = FormBorderStyle.None;
            nameForm.TopLevel = false;
            pnToAdd.Controls.Add(nameForm);
            nameForm.Show();
        }
    }
}
