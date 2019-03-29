using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL.Service
{
    public class BLL_Catogory
    {
        private DAL_Catogory dal_catogory;

        public DataTable getCatogory()
        {
            try
            {
                return dal_catogory.getCatogory();
            }
            catch
            {
                return null;
            }
        }

        public int addCatogory(string catogoryName)
        {
            try
            {
                DTO_Catogory dto_catogory = new DTO_Catogory();

                dto_catogory.CatogoryId = dal_catogory.increment();
                dto_catogory.CatogoryName = catogoryName;

                return dal_catogory.addCatogory(dto_catogory) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }

        public int deleteCatogory(long catogoryId)
        {
            try
            {
                return dal_catogory.deleteCatogory(catogoryId) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }

        public int editCatogory(long catogoryId, string catogoryName)
        {
            try
            {
                DTO_Catogory dto_catogory = new DTO_Catogory();

                dto_catogory.CatogoryId = catogoryId;
                dto_catogory.CatogoryName = catogoryName;

                return dal_catogory.editCatogory(dto_catogory) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }
    }
}
