using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Permission;
using DTO;

namespace BLL.Service
{
    public class BLL_Account
    {
        private DAL_Account dal_account;
        private CheckAuth checkPermission;
        public int Login(string id, string pass)
        {
            DataTable da = new DataTable();
            da = dal_account.Login(id, pass);
            if (da.Rows.Count > 0)
            {
                return 200;
            }
            else
            {
                return 404;
            }
        }

        public int addAccount(string userName, string id, string pass, string address, string avt, long phone)
        {
            DTO_Account dto_account = new DTO_Account();
            long temp = dal_account.increment();
            if (temp == 1998) temp += 1;
            dto_account.UserId = temp;
            dto_account.UserName = userName;
            dto_account.Id = id;
            dto_account.Pass = pass;
            dto_account.Address = address;
            dto_account.Phone = phone;

            try
            {
                return dal_account.addAccount(dto_account) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }

        public int editAccount(long userId, string userName, string id, string pass, string address, string avt, long phone, bool sessionAuth)
        {
            DTO_Account dto_account = new DTO_Account();

            dto_account.UserId = userId;
            dto_account.UserName = userName;
            dto_account.Id = id;
            dto_account.Pass = pass;
            dto_account.Address = address;
            dto_account.Phone = phone;

            try
            {
                if (checkPermission.checkAuth(sessionAuth))
                {
                    if (checkPermission.isAdmin(userId)/*|| checkRoleAccount.checkRole(userId)*/)
                        return dal_account.editAccount(dto_account) == true ? 200 : 400;
                    else return 403;
                }
                else return 403;

            }
            catch
            {
                return 400;
            }
        }

        public int deleteAccount(long userId, bool sessionAuth)
        {
            try
            {
                if (checkPermission.checkAuth(sessionAuth) && checkPermission.isAdmin(userId))
                    return dal_account.deleteAccount(userId) == true ? 200 : 400;
                else return 403;
            }
            catch
            {
                return 400;
            }
        }

        public bool checkId(string id)
        {
            return dal_account.checkId(id).Rows.Count > 0 ? true : false;
        }
    }
}
