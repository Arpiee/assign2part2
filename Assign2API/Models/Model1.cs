using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign2API.Models
{
    public class Model1 : DbContext
    {
        // onstructor
        public Model1(DbContextOptions<Model1>options) : base(options)
        {

        }
        public DbSet<Chopper> Choppers { get; set; }
    }
}
