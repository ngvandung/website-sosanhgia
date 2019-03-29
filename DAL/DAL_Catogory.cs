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
    public class DAL_Catogory : Connecting
    {
        public DataTable getCatogory()
        {
            try
            {
                SqlCommand command = new SqlCommand("stp_getCatogory", conn);
                command.CommandType = CommandType.StoredProcedure;
                openConnect();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                closeConnect();
                return dt;
            }
            catch
            {
                closeConnect();
                return null;
            }
        }

        public bool addCatogory(DTO_Catogory dto_catogory)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_addCatogory", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@madm", dto_catogory.CatogoryId);
                cmd.Parameters.AddWithValue("@tendm", dto_catogory.CatogoryName);
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

        public bool deleteCatogory(long catogoryId)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_deleteCatogory", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@madm", catogoryId);
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

        public bool editCatogory(DTO_Catogory dto_catogory)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_editCatogory", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@madm", dto_catogory.CatogoryId);
                cmd.Parameters.AddWithValue("@tendm", dto_catogory.CatogoryName);
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
                SqlCommand cmd = new SqlCommand("stp_incrementCatogory", conn); //Tên store procedure
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
    }
}
