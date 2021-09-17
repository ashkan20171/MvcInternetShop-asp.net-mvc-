using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInternetShop.Models.EntityModels
{
    internal class CityMetaData
    {
        [ScaffoldColumn(false)]
        [Bindable(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "نام شهر را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام شهر")]
        [Display(Name = "نام شهر")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "استان را انتخاب کنید کنید", AllowEmptyStrings = false)]
        [DisplayName("استان")]
        [Display(Name = "استان")]
        [ScaffoldColumn(false)]
        public int OstanId { get; set; }
    }

}

namespace MvcInternetShop.Models.DomainModels
{
    [MetadataType(typeof(MvcInternetShop.Models.EntityModels.CityMetaData))]
    public partial class City
    {
    }
}


