using Foodmoji_Domain.Models;
using Foodmoji_Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Foodmoji_Domain;

namespace Foodmoji_Application.Repository.RepositoryBase
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public ApplicationDbContext ApplicationDbContext { get; set; }
        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        public IQueryable<T> FindAll()
        {
            return ApplicationDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return ApplicationDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            ApplicationDbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
             ApplicationDbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
             ApplicationDbContext.Set<T>().Remove(entity);
        }
        public void Save()

        {

            ApplicationDbContext.SaveChanges();

        }

        private bool disposed = false;



        protected virtual void Dispose(bool disposing)

        {

            if (!this.disposed)

            {

                if (disposing)

                {

                    ApplicationDbContext.Dispose();

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
