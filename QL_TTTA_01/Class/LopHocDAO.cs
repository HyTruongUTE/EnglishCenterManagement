using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public class LopHocDAO
    {
        DataBase db = new DataBase();
        public void LoadLop(Bunifu.UI.WinForms.BunifuDropdown cbbMaLop)
        {
            cbbMaLop.DisplayMember = "malophoc";
            cbbMaLop.Text = "Class";
        }
        public DataTable LoadCbbLopForAdmin()
        {
            return db.SelectData("Select malophoc from tblLopHoc",null);
        }
        public DataTable LoadCbbLopForGiaoVien(string agent)
        {
            return db.LoadData(agent, "SelectAllMaLopForGiaoVien");
        }
        public DataTable LoadCbbLopForHocVien(string agent)
        {
            return db.LoadData(agent, "SelectAllMaLopForHocVien");
        }
        public DataTable LoadCbbLop()
        {
           return db.LoadData("load", "Select *from tblLopHoc");
        }
        public DataTable LoadDgvLop(string agent)
        {
           return db.LoadData(agent , "SelectAllLopHoc");
        }
        public DataTable SearchLopHocFormKhoaHoc(string agent)
        {
           return db.LoadData(agent, "SelectAllLopHocFromMaKhoa");
        }
        public int DeleteClass(string agent)
        {
           return db.DeleteData(agent, "DeleteLopHoc");
        }
        public DataRow CatchDataLopHoc(string malophoc)
        {
           return db.Select("SelectLopHoc '" + malophoc + "'");
        }
        public int InsertLopHoc(List<CustomParameter> lstpara)
        {         
           return db.Excute("InsertLopHoc", lstpara);
        }
        public int UpdateLopHoc(List<CustomParameter> lstpara,string malophoc)
        {
            lstpara.Insert(0, new CustomParameter()
            {
                key = "@malophoc",
                value = malophoc
            });
           return db.Excute("UpdateLopHoc", lstpara);
        }
        public List<CustomParameter> LoadDataLopHoc (string nguoiThucHien , string khoaHoc,string giaoVien,
            string thoiGianBatDau , string ThoiGianKetThuc ,string buoi1 , string buoi2 , string buoi3)
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
                value = khoaHoc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = giaoVien
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@thoigianbatdau",
                value = thoiGianBatDau
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@thoigianketthuc",
                value = ThoiGianKetThuc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@buoi1",
                value = buoi1
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@buoi2",
                value = buoi2
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@buoi3",
                value = buoi3
            });
            return lstpara;
        }
    }
}
