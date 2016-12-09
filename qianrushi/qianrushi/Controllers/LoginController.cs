using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qianrushi.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        //返回登陆页面
        public ActionResult Login()
        {
            return View();
        }


	}
}