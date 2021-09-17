using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class ShowGroupsViewModel
{
    public IEnumerable<MvcInternetShop.Models.DomainModels.Product> Products { get; set; }
    public IEnumerable<MvcInternetShop.Models.DomainModels.Group> Groups { get; set; }
}