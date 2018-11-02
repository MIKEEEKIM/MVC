using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtest.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {


            return View();


        }

        [HttpPost]

        public ActionResult Login(Models.LoginMod loginMod)
        {

            if (loginMod.UserName=="wangyan" && loginMod.Password=="80808080")

            {
                Response.Write("correct!");
            }


            else
            {
                Response.Write("wrong!");


            }

            return View();



        }







    }
}