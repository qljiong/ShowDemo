using MJ.BLL;
using MJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            OptUserInfo us = new OptUserInfo();
            UserInfo result = us.GetModel(1);
            return View(result);
        }

        public JsonResult Get()
        {
            return Json("");
        }

    }
}
