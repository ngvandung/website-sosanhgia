using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Comment
    {
        private long commentId;
        private string content;
        private long productId;
        private long userId;
        private string date;

        public long CommentId
        {
            get
            {
                return commentId;
            }

            set
            {
                commentId = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
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

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
