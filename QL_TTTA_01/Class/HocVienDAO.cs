using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01
{
    public class HocVienDAO
    {
        DataBase db =new DataBase();
        public int DeleteStudent(string agent)
        {
             return db.DeleteData(agent, "DeleteHocVien");
        }
        public int DeleteKhoaDaDangKy(string maLop,string tukhoa)
        {
            var lstpara = new List<CustomParameter>()
                    {
                new CustomParameter
                        {
                           key = "@malophoc",
                           value= maLop,
                        },
                        new CustomParameter
                        {
                           key = "@tukhoa",
                           value= tukhoa,
                        }
                    };
            return db.Excute("DeleteKhoaDaDangKy", lstpara);
        }
        public int InsertStudent(List<CustomParameter> lstpara)
        {
            return db.Excute("ThemMoiHocVien", lstpara);
        }

        
        public int UpdateStudent(string maHocVien ,List<CustomParameter> lstpara)
        {
            lstpara.Insert(0, new CustomParameter()
            {
                key = "@mahocvien",
                value = maHocVien
            });
            return db.Excute("UpdateHocVien", lstpara);
        }
        public int UpdateNote(string maHocVien, string note)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = maHocVien
            }); ;
            lstpara.Add(new CustomParameter()
            {
                key = "@noidung",
                value = note
            });
            return db.Excute("NoteHocVien", lstpara);
        }
        public int InsertClassOfStudent(string maHocVien, string maLopHoc )
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@mahocvien",
                value = maHocVien
            }); ;
            lstpara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = maLopHoc
            });
            return db.Excute("DangKyHoc", lstpara);
        }
        public DataTable SearchCbbKhoa(string agent)
        {
            return db.LoadData(agent, "SelectAllHocVienFromMaKhoa");
        }
        public DataTable SearchCbbLop(string agent)
        {
            return db.LoadData(agent, "SelectAllHocVienFromMaLop");
        }
        public DataRow SelectInFoHocVien(string maHocVien) 
        {
            return db.Select("SelectHocVienInFo '" + maHocVien+"'");
        }
        public DataRow SelectNoteHocVien(string maHocVien)
        {
            return db.Select("SelectNoteHocVien '" + maHocVien + "'");
        }
        public DataTable SearchTimeTable(string agent)
        {
            return db.LoadData(agent, "SelectThoiKhoaBieuHocVien");
        }
        public DataTable LoadTuition(string agent)
        {
            return db.LoadData(agent, "SelectHocPhiHocVien");
        }
        public DataTable LoadScholarship(string agent)
        {
            return db.LoadData(agent, "SelectHocBong1HocVien");
        }
        public int UpdateScholarship(string maHocVien , string soTien)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = maHocVien
            }); ;
            lstpara.Add(new CustomParameter()
            {
                key = "@sotien",
                value = soTien
            });
            return db.Excute("UpdateHocBong1HocVien", lstpara);
        }
        public DataTable LoadDgvKhoaDaDangKy(string agent)
        {
            return db.LoadData(agent, "KhoaDaDangKy");
        }
        public DataTable LoadDgvLopDangKy(string agent)
        {
            return db.LoadData(agent, "DanhSachLopChuaDangKy");
        }

        public DataTable LoadDgvStudentBy(string agent)
        {
            return db.LoadData(agent, "SelectAllHocVien");
        }
        public DataTable LoadLearningOutcomeBy(string mahocvien,string agent)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@mahocvien",
                value = mahocvien
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = agent
            });
            return db.SelectData("TraCuuDiem", lstpara);
        }
        public List<CustomParameter> LoadDataStudent( string ho ,string tendem , string ten , DateTime ngaysinh,           
                                                      string gioitinh ,string diachi ,string email ,string dienthoai )
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
            return lstpara;
        }
    }
}
