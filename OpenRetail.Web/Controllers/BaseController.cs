using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenRetail.Web.DBContext;

namespace OpenRetail.Web.Controllers
{
    public class BaseController<TEntity> : Controller where TEntity : class
    {
        protected UFI_TRANINGContext baseContext;

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null)
        {
            IEnumerable<TEntity> query;
            if (predicate == null)
                query = baseContext.Set<TEntity>().ToList();
            else
                query = baseContext.Set<TEntity>().Where(predicate);
            return query;
        }

    }
}