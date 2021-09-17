using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInternetShop.Models.EntityModels
{
    internal class ResellerMetaData
    {
        [ScaffoldColumn(false)]
        [Bindable(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "نام نمایندگی را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام نمایندگی")]
        [Display(Name = "نام نمایندگی")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "استان را انتخاب کنید کنید", AllowEmptyStrings = false)]
        [DisplayName("استان")]
        [Display(Name = "استان")]
        [ScaffoldColumn(false)]
        public int OstanId { get; set; }

        [DisplayName("شهر")]
        [Display(Name = "شهر")]
        [ScaffoldColumn(false)]
        public int CityId { get; set; }

        [DisplayName("آدرس نمایندگی")]
        [Display(Name = "آدرس نمایندگی")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, ErrorMessage = "این فیلد باید حداکثر 500 کاراکتر باشد")]
        public string Address { get; set; }
    }

}

namespace MvcInternetShop.Models.DomainModels
{
    [MetadataType(typeof(MvcInternetShop.Models.EntityModels.ResellerMetaData))]
    public partial class Reseller
    {
    }
}


