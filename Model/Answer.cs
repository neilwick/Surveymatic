using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Surveymatic.Model
{
    public partial class Answer
    {
        [Key]
        public int AnswerId { get; set; }
   
        public int QuestionId { get; set; }
        public int PersonId { get; set; }
        public int AnswerInt { get; set; }
        public string AnswerTxt { get; set; }

        public virtual Question Question { get; set; }
     
    }
}
