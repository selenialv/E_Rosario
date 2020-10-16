using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Rosario.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the E_RosarioUser class
    public class E_RosarioUser : IdentityUser
    {
        [PersonalData]
        [Column (TypeName ="varchar(100)")]
        public string FirstName { get; set;  }

        [PersonalData]
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }
    }
}
