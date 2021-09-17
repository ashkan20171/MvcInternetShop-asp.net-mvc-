using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcInternetShop.Models.DomainModels;
using MvcInternetShop.Models.Repositories;
using MvcInternetShop.ViewModels.Test;

namespace MvcInternetShop.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            string date = "1393/07/08";
            string time = "21:05";
            string datetime = "1393/07/08 21:05";



            return View();
        }

        [HttpGet]
        public ActionResult AddReseller()
        {
            var blOstan = new OstanRepository();
            var model = new AddResellerViewModel();
            model.Ostans = blOstan.Select().ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddReseller(Reseller reseller)
        {
            if (ModelState.IsValid)
            {
                var blReseller = new ResellerRepository();
                if (blReseller.Add(reseller))
                {
                    //ViewBag.Message = "نمایندگی ثبت شد";
                    return MessageBox.Show("نمایندگی ثبت شد", MessageType.Success);
                }
                else
                {
                    //ViewBag.Message = "نمایندگی ثبت نشد";
                    return MessageBox.Show("نمایندگی ثبت نشد", MessageType.Error);
                }
            }
            else
            {
                //ViewBag.Message = "مقادر ورودی نا معتبر است";
                return MessageBox.Show("مقادر ورودی نا معتبر است", MessageType.Error);
            }


            //var blOstan = new OstanRepository();
            //var model = new AddResellerViewModel();
            //model.Ostans = blOstan.Select().ToList();
            //model.Reseller = reseller;
            //return View(model);
        }

        [HttpPost]
        public ActionResult GetCities(int ostanId)
        {

            var blCity = new CityRepository();
            var model = new CityDrpViewModel();
            model.Cities = blCity.Where(p => p.OstanId == ostanId).ToList();
            return PartialView("_CityDropDownList", model);
        }


        [HttpGet]
        public ActionResult List()
        {
            var blReseller = new ResellerRepository();
            return View(blReseller.Select().ToList());
        }

        [HttpPost]
        public ActionResult Search(string txtSearchName, string txtSearchAddress)
        {
            System.Threading.Thread.Sleep(2000);

            var blReseller = new ResellerRepository();

            var model = blReseller.Where(p => p.Name.Contains(txtSearchName) && p.Address.Contains(txtSearchAddress)).ToList();


            return PartialView("_SearchReseller", model);
        }

        public ActionResult RenderResellers()
        {
            var blReseller = new ResellerRepository();
            var model = blReseller.Select().OrderByDescending(p => p.Id).Take(10).ToList();

            return PartialView("_RenderResellers", model);
        }
    }
}
