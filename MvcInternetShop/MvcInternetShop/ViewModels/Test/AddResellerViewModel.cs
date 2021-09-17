using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcInternetShop.Models.DomainModels;

namespace MvcInternetShop.ViewModels.Test
{
    public class AddResellerViewModel
    {
        public Reseller Reseller { get; set; }

        public IEnumerable<Ostan> Ostans { get; set; }
    }
}