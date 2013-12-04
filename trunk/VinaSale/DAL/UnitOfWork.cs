using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinaSale.Models;

namespace VinaSale.DAL
{
    public class UnitOfWork : IDisposable
    {
        private VinaSaleContext context = new VinaSaleContext();
        private GenericRepository<Event> adminPostRepository;

        public GenericRepository<Event> EventRepository
        {
            get
            {

                if (this.adminPostRepository == null)
                {
                    this.adminPostRepository = new GenericRepository<Event>(context);
                }
                return adminPostRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}