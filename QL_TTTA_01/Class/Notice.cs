using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranHuuQuocHuy_21110888;

namespace QL_TTTA_01.Class
{
    public class Notice
    {
        DataBase db = new DataBase();
        public DataTable SelectNoticeByAdmin()
        {
            return db.SelectData("SelectThongBaoByAdmin",null);
        }
        public DataTable SelectNoticeByGiaoVien(string maGiaoVien)
        {
            return db.LoadData(maGiaoVien, "SelectThongBaoByGiaoVien");
        }
        public DataTable SelectNoticeByHocVien(string maHocVien)
        {
            return db.LoadData(maHocVien, "SelectThongBaoByHocVien");
        }
        public DataTable SelectNoticeByLop(string maLop)
        {
            return db.LoadData(maLop, "SelectThongBaoByLop");
        }
        public int DeleteNotice(string agent)
        {
            return db.DeleteData(agent, "DeleteThongBao");
        }
        public int UpdateSeenThongBaoByAdmin(string agent)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@mathongbao",
                value = agent
            });
            return db.Excute("UpdateSeenThongBaoByAdmin",lstpara);
        }
        public int UpdateSeenByGiaoVienOrHocVien(string mathongbao , string user)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@maUser",
                value = user 
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@mathongbao",
                value = mathongbao 
            });

            return db.Excute("UpdateSeenThongBaoByHocVienOrGiaoVien", lstpara);
        }
        public int InsertNotice( string maNguoiGui , string maLopHoc, string tieuDe , string noiDung)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@nguoigui",
                value = maNguoiGui
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = maLopHoc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@tieude",
                value = tieuDe
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@noidung",
                value = noiDung
            });

            return db.Excute("InsertThongBao", lstpara);
        }
    }
}
