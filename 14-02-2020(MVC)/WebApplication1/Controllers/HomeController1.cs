using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController1 : Controller
    {
        public JsonResult Index()
        {
            return Json(new { id = 1, name = "sunil" });
        }
    }
}
