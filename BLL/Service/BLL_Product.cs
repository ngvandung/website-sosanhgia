using BLL.Permission;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class BLL_Product
    {
        private DAL_Product dal_products;
        private CheckAuth checkPermission;
        public DataTable getAllProducts()
        {
            try
            {
                return dal_products.getAllProducts();
            }
            catch
            {
                return null;
            }
        }

        public DataTable getByDanhMuc(string danhmuc)
        {
            try
            {
                return dal_products.getByDanhMuc(danhmuc);
            }
            catch
            {
                return null;
            }
        }

        public int addProduct(string nameProduct, string infoProduct, long categoryId, long brandId, long userId, bool sessionAuth)
        {
            try
            {
                if (checkPermission.checkAuth(sessionAuth))
                {
                    DTO_Product dto_product = new DTO_Product();

                    dto_product.ProductId = dal_products.increment();
                    dto_product.NameProduct = nameProduct;
                    dto_product.InfoProduct = infoProduct;
                    dto_product.CategoryId = categoryId;
                    dto_product.BrandId = brandId;
                    dto_product.Point = 0;
                    dto_product.UserId = userId;

                    if (dal_products.addProduct(dto_product))
                        return 200;
                    else return 400;
                }
                else return 403;
            }
            catch
            {
                return 400;
            }
        }

        public int deleteProduct(long productId, long userId, bool sessionAuth)
        {
            try
            {
                if (checkPermission.checkAuth(sessionAuth))
                {
                    //if (checkRoleProduct.checkRole(productId, userId) || checkPermission.isAdmin(userId))
                    //{
                    if (dal_products.deleteProduct(productId))
                        return 200;
                    else return 400;
                    //}
                    //else return false;
                }
                else return 403;
            }
            catch
            {
                return 400;
            }
        }

        public int editProduct(long productId, string nameProduct, string infoProduct, long categoryId, long brandId, long userId, bool sessionAuth)
        {
            try
            {
                if (checkPermission.checkAuth(sessionAuth))
                {
                    DTO_Product dto_product = new DTO_Product();

                    dto_product.ProductId = productId;
                    dto_product.NameProduct = nameProduct;
                    dto_product.InfoProduct = infoProduct;
                    dto_product.CategoryId = categoryId;
                    dto_product.BrandId = brandId;
                    dto_product.Point = dal_products.getPoint();
                    dto_product.UserId = userId;

                    //if (checkRoleProduct.checkRole(dto_product.ProductId, userId) || checkPermission.isAdmin(userId))
                    // {
                    if (dal_products.editProduct(dto_product))
                        return 200;
                    else return 400;
                    //}
                   // else return false;
                }
                else return 403;
            }
            catch
            {
                return 400;
            }
        }
    }
}
