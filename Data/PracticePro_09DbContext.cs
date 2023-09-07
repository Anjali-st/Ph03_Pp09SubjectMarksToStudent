using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppliPracticePro_09.Models;

namespace WebAppliPracticePro_09.Data
{
    public class PracticePro_09DbContext : DbContext
    {
        public PracticePro_09DbContext (DbContextOptions<PracticePro_09DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppliPracticePro_09.Models.RainbowSchool> RainbowSchool { get; set; } = default!;
    }
}
