using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ProductImage
    {
        private long imageId;
        private long productId;
        private string image;

        public long ImageId
        {
            get
            {
                return imageId;
            }

            set
            {
                imageId = value;
            }
        }

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

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }
    }
}
