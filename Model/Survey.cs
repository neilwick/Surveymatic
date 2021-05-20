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
            Surveytranslations = new HashSet<Surveytranslation>();
        }

        public int SurveyId { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Surveytranslation> Surveytranslations { get; set; }
    }
}
