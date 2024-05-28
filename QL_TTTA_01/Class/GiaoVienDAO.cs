using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public class GiaoVienDAO
    {
        DataBase db = new DataBase();
        public int DeleteTeacher(string agent)
        {
            return db.DeleteData(agent, "DeleteGiaoVien");
        }
        public int InsertTeacher(List<CustomParameter> lstpara)
        {
            return db.Excute("ThemMoiGiaoVien", lstpara);
        }
        public int UpdateTeacher(string maHocVien, List<CustomParameter> lstpara)
        {
            lstpara.Insert(0, new CustomParameter()
            {
                key = "@magiaovien",
                value = maHocVien
            });
            return db.Excute("UpdateGiaoVien", lstpara);
        }
        public int UpdateNote(string maGiaoVien, string note)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = maGiaoVien
            }); ;
            lstpara.Add(new CustomParameter()
            {
                key = "@noidung",
                value = note
            });
            return db.Excute("NoteGiaoVien", lstpara);
        }
        public DataRow SelectInFoGiaoVien(string maGiaoVien)
        {
            return db.Select("SelectGiaoVienInFo '" + maGiaoVien + "'");
        }
        public DataRow SelectNoteGiaoVien(string maGiaoVien)
        {
            return db.Select("SelectNoteGiaoVien '" + maGiaoVien + "'");
        }
        public DataTable SearchIdTen()
        {
            return db.LoadData("load", "SelectMaTenGiaovien");
        }
        public DataTable SearchCbbKhoa(string agent)
        {
            return db.LoadData(agent, "SelectAllGiaoVienFromMaKhoa");
        }
        public DataTable SearchTimeTable(string agent)
        {
            return db.LoadData(agent, "SelectThoiKhoaBieuGiaoVien");
        }
        public string LoadThuong(string agent)
        {
            return db.LoadData(agent, "SelectThuong").Rows[0]["thuong"].ToString();
        }

        public int UpdateThuong(string maGiaoVien , string soTien)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = maGiaoVien
            }); ;
            lstpara.Add(new CustomParameter()
            {
                key = "@sotien",
                value = soTien
            });
            return db.Excute("UpdateThuongGiaoVien", lstpara);
        }
        public DataTable LoadSalary(string agent)
        {
            return db.LoadData(agent, "SelectLuongGiaoVien");
        }
        public DataTable LoadBonus(string agent)
        {
            return db.LoadData(agent, "SelectThuong1GiaoVien");
        }
        public DataTable LoadDgvTeacherBy(string agent)
        {
            return db.LoadData(agent, "SelectAllGiaoVien");
        }
        public List<CustomParameter> LoadDataTeacher(string ho, string tendem, string ten, DateTime ngaysinh,
                                                      string gioitinh, string diachi, string email, string dienthoai,string toeic , string ielts)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@Ho",
                value = ho
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Tendem",
                value = tendem
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Ten",
                value = ten
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Gioitinh",
                value = gioitinh
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Diachi",
                value = diachi
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Dienthoai",
                value = dienthoai
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Email",
                value = email
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@toeic",
                value = toeic
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@ielts",
                value = ielts
            });
            return lstpara;
        }
    }
}
