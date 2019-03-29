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
    public class DAL_Product : Connecting
    {
        public DataTable getAllProducts()
        {
            try
            {
                SqlCommand command = new SqlCommand("stp_getAllProducts", conn);
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

        public DataTable getByDanhMuc(string categoryId)
        {
            try
            {
                SqlCommand command = new SqlCommand("stp_getByDanhMuc", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@danhmuc", categoryId);
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

        public long GetMatkFromProduct(long productId)
        {
            try
            {
                openConnect();
                SqlCommand command = new SqlCommand("stp_getMatkFromProduct", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@masp", productId);
                long _masp = (long)command.ExecuteScalar();
                closeConnect();
                return _masp;
            }
            catch
            {
                closeConnect();
                return -1;
            }
        }

        public bool addProduct(DTO_Product dto_product)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_addProduct", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@masp", dto_product.ProductId);
                cmd.Parameters.AddWithValue("@tensp", dto_product.NameProduct);
                cmd.Parameters.AddWithValue("@thongtin", dto_product.InfoProduct);
                cmd.Parameters.AddWithValue("@madm", dto_product.CategoryId);
                cmd.Parameters.AddWithValue("@math", dto_product.BrandId);
                cmd.Parameters.AddWithValue("@diemdanhgia", dto_product.Point);
                cmd.Parameters.AddWithValue("@matk", dto_product.UserId);
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

        public bool deleteProduct(long productId)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_deleteProduct", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@masp", productId);
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

        public bool editProduct(DTO_Product dto_product)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_editProduct", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                cmd.Parameters.AddWithValue("@masp", dto_product.ProductId);
                cmd.Parameters.AddWithValue("@tensp", dto_product.NameProduct);
                cmd.Parameters.AddWithValue("@thongtin", dto_product.InfoProduct);
                cmd.Parameters.AddWithValue("@madm", dto_product.CategoryId);
                cmd.Parameters.AddWithValue("@math", dto_product.BrandId);
                cmd.Parameters.AddWithValue("@diemdanhgia", dto_product.Point);
                cmd.Parameters.AddWithValue("@matk", dto_product.UserId);
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
                SqlCommand cmd = new SqlCommand("stp_incrementProduct", conn); //Tên store procedure
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

        public int getPoint()
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("stp_getPoint", conn); //Tên store procedure
                cmd.CommandType = CommandType.StoredProcedure; //Cho biết đây là store procedure
                int temp = (int)cmd.ExecuteScalar();
                closeConnect();
                return temp;
            }
            catch
            {
                closeConnect();
                return 0;
            }
        }
    }
}
