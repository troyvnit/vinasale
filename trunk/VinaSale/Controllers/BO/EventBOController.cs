using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using VinaSale.Models;
using VinaSale.DAL;
using VinaSale.Models.ViewModels;

namespace VinaSale.Controllers.BO
{
    public class EventBOController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: /AdminPostBO/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List([DataSourceRequest]DataSourceRequest request)
        {
            var adminposts = unitOfWork.EventRepository.Get().Select(Mapper.Map<Event, EventVM>);
            return Json(adminposts.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        // GET: /AdminPostBO/Create
        public ActionResult Create(int? id)
        {
            if (id == null) return View(new EventVM());
            var existEvent = Mapper.Map<Event, EventVM>(unitOfWork.EventRepository.GetByID((int) id)) ?? new EventVM();
            return View(existEvent);
        }

        // POST: /AdminPostBO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventVM eventVM)
        {
            if (ModelState.IsValid)
            {
                var adminPost = Mapper.Map<EventVM, Event>(eventVM);
                unitOfWork.EventRepository.Insert(adminPost);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(eventVM);
        }
    }
}
