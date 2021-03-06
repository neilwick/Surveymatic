using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Surveymatic.Model.LoginData
{
    public class SiteUser
    {
        public int SiteUserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        // ErrorMessage = "Characters are not allowed.")]
        public string Password { get; set; }

        [Required]
        [DefaultValue("false")]
        public Boolean EmailConfirmation { get; set; }

        [Required]
        [DefaultValue(0)]
        public int AccessFailedCount { get; set; }

        //[Required]
        //public string RecoveryAnswer1 {get;set;}

        //[Required]
        //public string RecoveryAnswer2 {get;set;}

        //[Required]
        //public string RecoveryAnswer3 {get;set;}

        public virtual List<SiteRole> Roles {get; set;}
    }
}
