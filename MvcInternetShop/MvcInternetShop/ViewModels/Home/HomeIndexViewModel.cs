using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcInternetShop.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public IEnumerable<MvcInternetShop.Models.DomainModels.Group> Groups { get; set; }
        public IEnumerable<MvcInternetShop.Models.DomainModels.Product> Products { get; set; }
        public IEnumerable<MvcInternetShop.Models.DomainModels.Product> BestSellersProducts { get; set; }
        public IEnumerable<MvcInternetShop.Models.DomainModels.Product> OffProducts { get; set; }
    }
}