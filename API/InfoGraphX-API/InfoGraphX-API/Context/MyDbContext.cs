using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoGraphX_API.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoGraphX_API.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ForeignTradeValueIndice> ForeignTradeValueIndices { get; set; }
        public DbSet<HappinessLevelByAgeGroup> HappinessLevelByAgeGroups { get; set; }
        public DbSet<HappinesRates> HappinesRates{ get; set; }

        public DbSet<Tufe> Tufe { get; set; }


    }
}
