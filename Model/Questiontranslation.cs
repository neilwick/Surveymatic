using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Surveymatic.Model
{
    public partial class QuestionTranslation
    {
            [Key]
        public int QuestionTranslatonId { get; set; }
        public int QuestionId { get; set; }
        public string Language { get; set; }
        public int Type { get; set; }
        public string Text { get; set; }

        public virtual Question Question { get; set; }
    }
}
