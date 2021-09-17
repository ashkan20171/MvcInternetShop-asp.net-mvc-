using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcInternetShop.Models.DomainModels;

namespace MvcInternetShop.ViewModels.Test
{
    public class CityDrpViewModel
    {
        public Reseller Reseller { get; set; }

        public IEnumerable<City> Cities { get; set; }
    }
}