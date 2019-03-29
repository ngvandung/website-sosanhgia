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
    public class DAL_PriceHistory : Connecting
    {
        public DataTable getPriceHistory()
        {
            try
            {
                SqlCommand command = new SqlCommand("stp_getPriceHistory", conn);
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

        public bool addPriceHistory(DTO_PriceHistory dto_pricehistory)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_addPriceHistory", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@masp", dto_pricehistory.ProductId);
                cmd.Parameters.AddWithValue("@ngay", dto_pricehistory.Date);
                cmd.Parameters.AddWithValue("@gia", dto_pricehistory.Price);
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

        public bool deletePriceHistory(long productId, string date)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_deletePriceHistory", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@masp", productId);
                cmd.Parameters.AddWithValue("@ngay", date);
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

        public bool editPriceHistory(DTO_PriceHistory dto_pricehistory)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_editPriceHistory", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@masp", dto_pricehistory.ProductId);
                cmd.Parameters.AddWithValue("@ngay", dto_pricehistory.Date);
                cmd.Parameters.AddWithValue("@gia", dto_pricehistory.Price);
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
                SqlCommand cmd = new SqlCommand("stp_incrementPriceHistory", conn); //Tên store procedure
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
