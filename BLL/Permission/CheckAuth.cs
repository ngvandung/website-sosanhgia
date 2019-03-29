using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Permission
{
    public class CheckAuth
    {
        public bool checkAuth(bool sessionAuth)
        {
            if (sessionAuth == true)
                return true;
            else return false;
        }

        public bool isAdmin(long userId)
        {
            if (userId == 1998)
                return true;
            else return false;
        }
    }
}
