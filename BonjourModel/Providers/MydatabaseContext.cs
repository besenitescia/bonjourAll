using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourModel.Providers
{
    public class MydatabaseContext : DbContext
    {
        public DbSet<Personne> personnes { get; set; }
    }
}
