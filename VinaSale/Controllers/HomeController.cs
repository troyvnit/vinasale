using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using VinaSale.DAL;
using VinaSale.Models;
using VinaSale.Models.ViewModels;

namespace VinaSale.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public ActionResult Index()
        {
            var posts = unitOfWork.EventRepository.Get().Select(Mapper.Map<Event, EventVM>);
            ViewBag.Posts = posts;
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
    }
}