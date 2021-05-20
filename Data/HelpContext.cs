using System;
using Microsoft.EntityFrameworkCore;
using Surveymatic.Model;

namespace Surveymatic.Data
{
    public class HelpContext : DbContext
    {
        public HelpContext(DbContextOptions<HelpContext> options) : base(options)
        {

        }
        public DbSet<Help> Help { get; set; }
        public DbSet<HelpEntry> HelpEntry { get; set; }
    }
}