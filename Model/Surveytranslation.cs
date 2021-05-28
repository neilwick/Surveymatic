using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Surveymatic.Model
{
    public partial class SurveyTranslation
    {
        public SurveyTranslation()
        {
            Description = "";
            Title = "";
            Instruction = "";
        }
        [Key]
        public int SurveyTranslationId { get; set; }
        public int SurveyId { get; set; }

        [Required]
        public string Language { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Instruction { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
