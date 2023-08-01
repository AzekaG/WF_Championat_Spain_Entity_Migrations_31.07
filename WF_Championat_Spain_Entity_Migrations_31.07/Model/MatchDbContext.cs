using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WF_Championat_Spain_Entity_Migrations_31._07.Model
{
     class MatchDbContext : DbContext
    {

        public MatchDbContext() : base("MatchesDb")
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Matches> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }


      
    }
}
