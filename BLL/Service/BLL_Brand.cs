using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.Service
{
    public class BLL_Brand
    {
        private DAL_Brand dal_brand;

        public DataTable getBrand()
        {
            try
            {
                return dal_brand.getBrand();
            }
            catch
            {
                return null;
            }
        }

        public int addBrand(string BrandName)
        {
            try
            {
                DTO_Brand dto_brand = new DTO_Brand();

                dto_brand.BrandId = dal_brand.increment();
                dto_brand.BrandName = BrandName;

                return dal_brand.addBrand(dto_brand) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }

        public int deleteBrand(long brandId)
        {
            try
            {
                return dal_brand.deleteBrand(brandId) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }

        public int editBrand(long BrandId, string BrandName)
        {
            try
            {
                DTO_Brand dto_brand = new DTO_Brand();

                dto_brand.BrandId = BrandId;
                dto_brand.BrandName = BrandName;

                return dal_brand.editBrand(dto_brand) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }
    }
}
