using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Surveymatic.Model
{
    public partial class Survey
    {
        public Survey()
        {
            Questions = new HashSet<Question>();
            Surveytranslations = new HashSet<SurveyTranslation>();
        }

        [Key]
        public int SurveyId { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<SurveyTranslation> Surveytranslations { get; set; }
    }
}
