using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {
        private long productId;
        private string nameProduct;
        private string infoProduct;
        private long categoryId;
        private long brandId;
        private int point;
        private long userId;

        public long ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
            }
        }

        public string NameProduct
        {
            get
            {
                return nameProduct;
            }

            set
            {
                nameProduct = value;
            }
        }

        public string InfoProduct
        {
            get
            {
                return infoProduct;
            }

            set
            {
                infoProduct = value;
            }
        }

        public long CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }

        public long BrandId
        {
            get
            {
                return brandId;
            }

            set
            {
                brandId = value;
            }
        }

        public int Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public long UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }
    }
}
