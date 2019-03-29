using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Brand
    {
        private long brandId;
        private string brandName;

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

        public string BrandName
        {
            get
            {
                return brandName;
            }

            set
            {
                brandName = value;
            }
        }
    }
}
