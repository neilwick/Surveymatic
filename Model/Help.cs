using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Surveymatic.Model
{
    public class Help
    {
        [Key]
        public int HelpId { get; set; }
        public string HelpTag { get; set; }

        public List<HelpEntry> Entries { get; set; }


    }
}