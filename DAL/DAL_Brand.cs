using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Brand : Connecting
    {
        public DataTable getBrand()
        {
            try
            {
                SqlCommand command = new SqlCommand("stp_getBrand", conn);
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

        public bool addBrand(DTO_Brand dto_brand)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_addBrand", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@math", dto_brand.BrandId);
                cmd.Parameters.AddWithValue("@tenth", dto_brand.BrandName);
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

        public bool deleteBrand(long brandId)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_deleteBrand", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@math", brandId);
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

        public bool editBrand(DTO_Brand dto_brand)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_editBrand", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@math", dto_brand.BrandId);
                cmd.Parameters.AddWithValue("@tenth", dto_brand.BrandName);
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
                SqlCommand cmd = new SqlCommand("stp_incrementBrand", conn); //Tên store procedure
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
