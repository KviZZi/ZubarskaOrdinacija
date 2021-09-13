using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Database
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataBaseContext RepositoryContext { get; set; }
        protected DbSet<T> entities { get; set; }

        public RepositoryBase(DataBaseContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
            this.entities = repositoryContext.Set<T>();
        }

        public IQueryable<T> FindAll()
        {
            try
            {
                return this.RepositoryContext.Set<T>().AsNoTracking();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return null;
            }
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            try
            {
                return this.RepositoryContext.Set<T>()
                    .Where(expression).AsNoTracking();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return null;
            }
        }

        public bool Create(T entity)
        {
            try
            {
                this.RepositoryContext.Set<T>().Add(entity);
                return true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                this.RepositoryContext.Set<T>().Update(entity);
                return true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                this.RepositoryContext.Set<T>().Remove(entity);
                return true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
        }

        public async Task SaveAsync()
        {
            await this.RepositoryContext.SaveChangesAsync();
        }
    }
}