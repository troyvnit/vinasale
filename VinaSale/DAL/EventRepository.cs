using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinaSale.Models;

namespace VinaSale.DAL
{
    public class EventRepository: GenericRepository<Event>
    {
        public EventRepository(VinaSaleContext context)
            : base(context)
        {
        }

        public int UpdateCourseCredits(int multiplier)
        {
            return context.Database.ExecuteSqlCommand("UPDATE Event SET PostName = PostName + {0}", multiplier);
        }
    }
}