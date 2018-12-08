using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ItemsController : Controller
    {
        public IItemService _itemService;
        
        public ItemsController( IItemService itemService)
        {
           
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public object GetAllItems(DataSourceLoadOptions loadOptions)
        {
            var allItems = _itemService.GetAllItems();
            return DataSourceLoader.Load(allItems, loadOptions);
        }
    }
}