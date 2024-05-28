using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public class KhoaHocDAO
    {
        DataBase db= new DataBase();
        public void LoadKhoa(Bunifu.UI.WinForms.BunifuDropdown cbbMaKhoa)
        {
            cbbMaKhoa.DisplayMember = "makhoahoc";
            cbbMaKhoa.Text = "Course";
        }
        public DataTable LoadCbbKhoaForGiaoVien(string agent)
        {
            return db.LoadData(agent, "SelectAllMaKhoaForGiaoVien");
        }
        public DataTable LoadCbbKhoa()
        {
            return db.LoadData("load", "Select *from tblKhoaHoc");
        }
        public DataTable LoadDgvKhoaHoc(string agent)
        {
            return db.LoadData(agent, "SelectAllKhoaHoc");
        }
        public DataRow CatchKhoaHoc(string makhoa)
        {
            return db.Select("SelectKhoaHoc '" + makhoa + "'");
        }
        public int InsertKhoaHoc(List<CustomParameter> lstpara)
        {
            return db.Excute("InsertKhoaHoc", lstpara);
        }
        public int UpdateKhoaHoc(List<CustomParameter> lstpara, string makhoahoc)
        {
            return db.Excute("UpdateKhoaHoc", lstpara);
        }
        public int DeleteKhoaHoc( string makhoahoc)
        {
            return db.DeleteData( makhoahoc, "DeleteKhoaHoc");
        }
        public List<CustomParameter> LoadDataKhoaHoc(string nguoiThucHien, string makhoa, string khoaHoc, string sotien)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@nguoithuchien",
                value = nguoiThucHien
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@makhoahoc",
                value = makhoa
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@tenkhoahoc",
                value = khoaHoc
            });
            
            lstpara.Add(new CustomParameter()
            {
                key = "@sotien",
                value = sotien
            });
            return lstpara;
        }
    }
}
