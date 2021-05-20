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

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questiontranslation> Questiontranslations { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<Surveytranslation> Surveytranslations { get; set; }

    }
}