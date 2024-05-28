using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01.Class
{
    public class ScoreDAO
    {
        DataBase db = new DataBase();
        public DataTable LoadScoreAdmin()
        {
            return db.LoadData("load", "AdminSelectDiemHocVien");
        }
        public DataTable LoadScoreChartTeacher(string min,string max)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@diembe",
                value = min
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@diemlon",
                value = max
            });
            return db.SelectData("CountSvTheoDiem", lstpara);
        }
        public DataTable LoadScoreChartByKhoa(string agent)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@makhoahoc",
                value = agent
            });
            return db.SelectData("SLHocVienTheoDiemTbBykhoa", lstpara);
        }
        public DataTable LoadScoreChart()
        {
            return db.LoadData("load", "SoLuongHocVienTheoDiemTb");
        }
        public DataTable SearchCbbTukhoa(string user)
        {
            return db.LoadData(user, "SelectDiemFromMaHocVien");
        }
        public DataTable SearchCbbLop(string user)
        {
            return db.LoadData(user, "SelectDiemFromMaLop");
        }
        public DataTable SearchCbbKhoa(string user, string maKhoa)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = user
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@makhoahoc",
                value = maKhoa
            });
            if (!user.Contains("gv")) return db.LoadData(maKhoa, "SelectDiemFromMaKhoaByAdmin");
            else return db.SelectData("SelectDiemFromMaKhoa", lstpara);
        }
        public DataTable LoadScoreTeacher(string user )
        {
            return db.LoadData(user , "GiaoVienSelectDiemHocVien");
        }
        public int UpdateDiemHocVien(string mahocvien , string diemgiuaki , string diemcuoiki , string malophoc)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@mahocvien",
                value = mahocvien
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@diemthigiuaki",
                value = diemgiuaki
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@diemthicuoiki",
                value = diemcuoiki
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malophoc
            });
            return db.Excute("UpdateDiemHocVien", lstpara);
        }
    }

}
