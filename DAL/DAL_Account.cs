using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_Account : Connecting
    {
        public DataTable Login(string id, string pass)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_login", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@id", id); //Tên tham số và giá trị truyền vào tương ứng
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable da = new DataTable();
                adapter.Fill(da);
                closeConnect(); //Đóng kết nối
                return da;
            }
            catch
            {
                closeConnect();
                return null;
            }

        }

        public string getMatk(string id, string pass)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_getmatk", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@id", id); //Tên tham số và giá trị truyền vào tương ứng
                cmd.Parameters.AddWithValue("@pass", pass);
                string _matk = cmd.ExecuteScalar().ToString();
                closeConnect();
                return _matk;
            }
            catch
            {
                closeConnect();
                return null;
            }
        }

        public string getTenTK(long userId)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_gettentk", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@id", userId); //Tên tham số và giá trị truyền vào tương ứng
                string _tentk = cmd.ExecuteScalar().ToString();
                closeConnect();
                return _tentk;
            }
            catch
            {
                closeConnect();
                return null;
            }

        }

        public bool addAccount(DTO_Account dto_account)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_addAccount", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@matk", dto_account.UserId);
                cmd.Parameters.AddWithValue("@id", dto_account.Id);
                cmd.Parameters.AddWithValue("@pass", dto_account.Pass);
                cmd.Parameters.AddWithValue("@ten", dto_account.UserName);
                cmd.Parameters.AddWithValue("@diachi", dto_account.Address);
                cmd.Parameters.AddWithValue("@anh", dto_account.Avt);
                cmd.Parameters.AddWithValue("@sdt", dto_account.Phone);
                cmd.ExecuteNonQuery();
                closeConnect(); //Đóng kết nối
                return true;
            }
            catch
            {
                closeConnect();
                return false;
            }
        }

        public bool deleteAccount(long userId)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_deleteAccount", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@matk", userId);
                cmd.ExecuteNonQuery();
                closeConnect(); //Đóng kết nối
                return true;
            }
            catch
            {
                closeConnect();
                return false;
            }
        }

        public bool editAccount(DTO_Account dto_account)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_editAccount", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@matk", dto_account.UserId);
                cmd.Parameters.AddWithValue("@id", dto_account.Id);
                cmd.Parameters.AddWithValue("@pass", dto_account.Pass);
                cmd.Parameters.AddWithValue("@ten", dto_account.UserName);
                cmd.Parameters.AddWithValue("@diachi", dto_account.Address);
                cmd.Parameters.AddWithValue("@anh", dto_account.Avt);
                cmd.Parameters.AddWithValue("@sdt", dto_account.Phone);
                cmd.ExecuteNonQuery();
                closeConnect(); //Đóng kết nối
                return true;
            }
            catch
            {
                closeConnect();
                return false;
            }
        }

        public long increment()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_incrementAccount", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                long temp = (long)cmd.ExecuteScalar();
                closeConnect();
                return temp;
            }
            catch
            {
                closeConnect();
                return 1;
            }
        }

        public DataTable checkId(string id)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_checkId", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@id", id); //Tên tham số và giá trị truyền vào tương ứng
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable da = new DataTable();
                adapter.Fill(da);
                closeConnect(); //Đóng kết nối
                return da;
            }
            catch
            {
                closeConnect();
                return null;
            }
        }
    }
}
