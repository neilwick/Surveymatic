using System;
using Microsoft.EntityFrameworkCore;
using Surveymatic.Model;

namespace Surveymatic.Data
{
    public class SurveymaticContext : DbContext
    {
        public SurveymaticContext(DbContextOptions<SurveymaticContext> options) : base(options)
        {

        }
        public DbSet<Help> Help { get; set; }
        public DbSet<HelpEntry> HelpEntry { get; set; }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionTranslation> QuestionTranslations { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyTranslation> SurveyTranslations { get; set; }

        // login
        public DbSet<SiteUser> SiteUsers { get; set; }
    }
}