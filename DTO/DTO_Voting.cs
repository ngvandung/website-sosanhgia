using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Voting
    {
        private long userId;
        private long productId;
        private int vote;

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

        public int Vote
        {
            get
            {
                return vote;
            }

            set
            {
                vote = value;
            }
        }
    }
}
