using Microsoft.EntityFrameworkCore;
using OpenRetail.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenRetail.Web.DBContext
{
    public class UFI_TRANINGContext : DbContext
    {
        public DbSet<EmployeeModel> Employee { get; set; }

        public UFI_TRANINGContext(DbContextOptions<UFI_TRANINGContext> options) : base(options)
        {

        }
    }
}
