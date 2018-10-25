using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenRetail.Web.DBContext;
using OpenRetail.Web.Models;

namespace OpenRetail.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class EmployeeController : BaseController<EmployeeModel>
    {
        public EmployeeController(UFI_TRANINGContext context)
        {
            baseContext = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<EmployeeModel> List()
        {
            return Get();
        }
    }
}