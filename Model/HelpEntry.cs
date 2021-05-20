using System;
using System.ComponentModel.DataAnnotations;

namespace Surveymatic.Model
{
    public class HelpEntry
    {
        [Key]
        public int HelpEntryId { get; set; }
        public Help Help { get; set; }
        public string Language { get; set; }

        public string Content { get; set; }


    }
}