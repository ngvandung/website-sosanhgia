using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SaleAddress
    {
        private long saleAddressId;
        private long productId;
        private string link;

        public long SaleAddressId
        {
            get
            {
                return saleAddressId;
            }

            set
            {
                saleAddressId = value;
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

        public string Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;
            }
        }
    }
}
