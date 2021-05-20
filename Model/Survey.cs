using System;
using System.Collections.Generic;

#nullable disable

namespace Surveymatic.Model
{
    public partial class Survey
    {
        public Survey()
        {
            Answers = new HashSet<Answer>();
            Questions = new HashSet<Question>();
            SurveyTranslations = new HashSet<SurveyTranslation>();
        }

        public int SurveyId { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<SurveyTranslation> SurveyTranslations { get; set; }
    }
}
