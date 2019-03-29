using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL.Service
{
    public class BLL_PriceHistory
    {
        private DAL_PriceHistory dal_pricehistory;

        public DataTable getPriceHistory()
        {
            try
            {
                return dal_pricehistory.getPriceHistory();
            }
            catch
            {
                return null;
            }
        }

        public int addPriceHistory(long productId, string date, float price)
        {
            try
            {
                DTO_PriceHistory dto_pricehistory = new DTO_PriceHistory();

                dto_pricehistory.ProductId = productId;
                dto_pricehistory.Date = date;
                dto_pricehistory.Price = price;

                return dal_pricehistory.addPriceHistory(dto_pricehistory) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }

        public int deletePriceHistory(long productId, string date)
        {
            try
            {
                return dal_pricehistory.deletePriceHistory(productId, date) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }

        public int editPriceHistory(long productId, string date, float price)
        {
            try
            {
                DTO_PriceHistory dto_pricehistory = new DTO_PriceHistory();

                dto_pricehistory.ProductId = productId;
                dto_pricehistory.Date = date;
                dto_pricehistory.Price = price;

                return dal_pricehistory.editPriceHistory(dto_pricehistory) == true ? 200 : 400;
            }
            catch
            {
                return 400;
            }
        }
    }
}
