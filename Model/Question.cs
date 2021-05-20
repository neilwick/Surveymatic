using System;
using System.Collections.Generic;

#nullable disable

namespace Surveymatic.Model
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            Questiontranslations = new HashSet<Questiontranslation>();
        }

        public int QuestionId { get; set; }
        public int SurveyId { get; set; }
        public int Order { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Questiontranslation> Questiontranslations { get; set; }
    }
}
