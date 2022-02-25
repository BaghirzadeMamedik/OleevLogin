

using Entities;
using Microsoft.EntityFrameworkCore;

namespace K205Oleev.Data
{
    public class OleevDbContext : DbContext
    {
        public OleevDbContext(DbContextOptions<OleevDbContext> options)
            : base(options) { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutLanguage> AboutLanguages { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<InfoLanguage> InfoLanguages { get; set; }
        public DbSet<CountDown> CountDowns { get; set; }
        public DbSet<CountDownLanguage> CountDownLanguages { get; set; }
        public DbSet<OurService> OurServices { get; set; }
        public DbSet<OurServiceLanguage> OurServiceLanguages { get; set; }
    }
}
