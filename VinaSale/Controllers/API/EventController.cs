using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using VinaSale.DAL;
using VinaSale.Models;
using VinaSale.Models.ViewModels;

namespace VinaSale.Controllers.API
{
    public class EventController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET api/event
        public IEnumerable<EventForListVM> Get()
        {
            var events = unitOfWork.EventRepository.Get().Select(Mapper.Map<Event, EventForListVM>).ToList();
            return events;
        }

        // GET api/event/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/event
        public void Post([FromBody]string value)
        {
        }

        // PUT api/event/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/event/5
        public void Delete(int id)
        {
        }
    }
}
