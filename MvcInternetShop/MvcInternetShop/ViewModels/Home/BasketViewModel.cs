using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class BasketViewModel
{
    public MvcInternetShop.Models.DomainModels.Product Product { get; set; }
    public int Count { get; set; }
}