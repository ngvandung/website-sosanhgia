using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Properties
    {
        private long propertiesId;
        private string propertiesName;
        private long productId;
        private string value;

        public long PropertiesId
        {
            get
            {
                return propertiesId;
            }

            set
            {
                propertiesId = value;
            }
        }

        public string PropertiesName
        {
            get
            {
                return propertiesName;
            }

            set
            {
                propertiesName = value;
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

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
