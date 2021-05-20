using System;
using System.Collections.Generic;

#nullable disable

namespace Surveymatic.Model
{
    public partial class QuestionTranslation
    {
        public int QuestionTranslationId { get; set; }
        public int QuestionId { get; set; }
        public string Language { get; set; }
        public int Type { get; set; }
        public string Text { get; set; }

        public virtual Question Question { get; set; }
    }
}
