using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Surveymatic.Model.LoginData
{
    public static class UserInfo
    {
        public static string Email { get; set; }
        public static string LoggedIn { get; set; }
        public static string PreferredLanguage { get; set; }

        public static SiteUser User {get;set;}

        public static bool HasRole (string roleName)
        {   
            if(User != null && User.Roles != null)     
            {
                foreach(var role in User.Roles)
                {
                    if (role.RoleName == roleName)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

    }
}
