using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Catogory
    {
        private long catogoryId;
        private string catogoryName;

        public long CatogoryId
        {
            get
            {
                return catogoryId;
            }

            set
            {
                catogoryId = value;
            }
        }

        public string CatogoryName
        {
            get
            {
                return catogoryName;
            }

            set
            {
                catogoryName = value;
            }
        }
    }
}
