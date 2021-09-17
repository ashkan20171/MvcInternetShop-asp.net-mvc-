using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInternetShop.Models.EntityModels
{
    internal class OstanMetaData
    {
        [ScaffoldColumn(false)]
        [Bindable(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "نام استان را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام استان")]
        [Display(Name = "نام استان")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }
    }

}

namespace MvcInternetShop.Models.DomainModels
{
    [MetadataType(typeof(MvcInternetShop.Models.EntityModels.OstanMetaData))]
    public partial class Ostan
    {
    }
}


