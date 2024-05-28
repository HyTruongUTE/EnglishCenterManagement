using QL_TTTA_01;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranHuuQuocHuy_21110888
{
    public class DataBase
    {     
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        public DataBase()
        {
            try
            {
                conn = new SqlConnection(QL_TTTA_01.Properties.Settings.Default.connStr);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected fail: " + ex.Message);
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> lstpara)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //sql = "exec  SelectAllSinhVien";
                cmd = new SqlCommand(sql, conn);
                if (lstpara != null)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var para in lstpara)
                    {
                        cmd.Parameters.AddWithValue(para.key, para.value);
                    }
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //dt.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi load Data " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

        }
        public DataTable LoadData(string tukhoa, string lenh)
        {
            
            List<CustomParameter> lstpara = new List<CustomParameter>();
            if (tukhoa != "load")
            {
                lstpara.Add(new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                });
            }
            else lstpara = null;
            return SelectData(lenh, lstpara);
        }
        public DataRow Select(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Loi load thong tin chi tiet " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
        public int DeleteData(string tukhoa, string sql)
        {
            int result = 0;
            if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Xác nhận xóa!!!",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstpara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                           key = "@tukhoa",
                           value= tukhoa,
                        }
                    };
                result = Excute(sql, lstpara);
                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
            }
            return result;
        }
        public int Excute(string sql, List<CustomParameter> lstpara)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstpara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi thuc thi cau lenh " + ex.Message);
                return -100;
            }
            finally
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
