using NewTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewTest.Controllers
{
    public class HomeController : Controller
    {
        //创建数据库上下文类的对象  
        FordTestEntities db = new FordTestEntities();

        public ActionResult Index()
        {
            return View();
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

        public ActionResult Test(String id)
        {
            //也可以使用Linq来获取数据   
            //List<Models.USERINFO> list1 = (from p in db.USERINFOes where p.infoId == 123 select p).ToList();
            return Content(id);
        }

        public String GetUserId()
        {
            return "";
        }
    }
}