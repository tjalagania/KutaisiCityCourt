using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class KcDbContext : DbContext
    {
        public KcDbContext(DbContextOptions<KcDbContext> options)
            : base(options)
        {

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Commands> Commands {get;set;}
        public DbSet<Position>Positions { get; set; }
        public DbSet<Palats> Palats { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Judge> Judges { get; set; }
        public DbSet<Galery>Galeries { get; set; }
        public DbSet<GaleryImgs>GaleryImages { get; set; }
        public DbSet<About>About { get; set; }
        public DbSet<AboutAtachFiles>AboutAtachFiles { get; set; }
        public DbSet<links> Links { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<AtachFiles>AtachFiles { get; set; }
        public DbSet<Cods> Codes { get; set; }
        public DbSet<Vacancy>Vacancies { get; set; }
        public DbSet<Statistic>Statistic { get; set; }
        public DbSet<Struct>Structura { get; set; }
    }
}
