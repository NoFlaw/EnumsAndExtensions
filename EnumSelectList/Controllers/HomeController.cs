using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using EnumsAndExtensions.Extensions;
using EnumsAndExtensions.Models;
using EnumsAndExtensions.Models.Enums;

namespace EnumsAndExtensions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new ListViewModel();

            IEnumerable<CoolEnum> enumList = Enum.GetValues(typeof(CoolEnum)).Cast<CoolEnum>();

            viewModel.SelectedEnumItemId = 2;

            viewModel.EnumList = from item in enumList
                                 select new SelectListItem
                                 {
                                    Text = item.ToDescription(), 
                                    Value = ((int)item).ToString(CultureInfo.InvariantCulture),
                                    Selected = (item.Equals(viewModel.SelectedEnumItemId))
                                 };

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}