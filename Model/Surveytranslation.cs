using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Surveymatic.Model
{
    public partial class SurveyTranslation
    {
        [Key]
        public int SurveyTranslationId { get; set; }
        public int SurveyId { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
