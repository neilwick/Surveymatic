using System;
using Microsoft.EntityFrameworkCore;


namespace Surveymatic.Data
{
    public class HelpContext : DbContext
    {
        public HelpContext(DbContextOptions<HelpContext> options) : base(options)
        {

        }
        public DbSet<EnglishHelp> EnglishHelp { get; set; }
        public DbSet<FrenchHelp> FrenchHelp { get; set; }
    }
}