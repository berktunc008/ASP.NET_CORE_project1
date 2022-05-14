using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webodevberk.Controllers
{
    public class ShopperController : Controller
    {
        private readonly IStringLocalizer<ShopperController> _localizer;

        public ShopperController(IStringLocalizer<ShopperController> localizer)
        {
            _localizer = localizer;
        }




        public IActionResult Index()
        {
            var message = _localizer["Message"];
            ViewData["Message"] = message;
            return View();
        }
    }
}
