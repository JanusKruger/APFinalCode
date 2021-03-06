﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APFinal2202.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult AuctionRoom ()
        {
            ViewBag.Message = "Auctionroom .";

            return View();
        }
        public ActionResult Properties()
        {
            ViewBag.Message = "Your Properties Page .";

            return View();
        }
        public ActionResult PropertyDetailPage()
        {
            ViewBag.Message = "Detail Page .";

            return View();
        }
        public ActionResult Terms()
        {
            ViewBag.Message = "Terms.";

            return View();
        }
        public ActionResult BuyersGuide()
        {
            ViewBag.Message = "BuyersGuide.";

            return View();
        }
        public ActionResult FAQ()
        {
            ViewBag.Message = "Questions.";

            return View();
        }
        public ActionResult SubmitProperty()
        {
            ViewBag.Message = "Submitproperty.";

            return View();
        }
        public ActionResult SellersGuide()
        {
            ViewBag.Message = "Seller Info.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Register.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Login.";

            return View();
        }
    }
}