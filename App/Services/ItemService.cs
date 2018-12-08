using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public class ItemService : IItemService
    {
        private static AP_CorpContext _dbcontext = new AP_CorpContext();
       

        public ItemService(AP_CorpContext dbcontext)
        {
            _dbcontext = dbcontext;
        }       

        public List<Items> GetAllItems()
        {
            var itemList = _dbcontext.Items.OrderBy(a => a.ItemId).ToList();
            return (itemList);
        }
    }
}
