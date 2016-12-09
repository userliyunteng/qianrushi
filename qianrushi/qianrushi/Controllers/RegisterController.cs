using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qianrushi.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        
        //返回注册页面
        public ActionResult Register()
        {
            return View();
        }
	}
}