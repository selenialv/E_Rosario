using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Rosario.Models
{
   
        public class CreateRoleViewModel
        {
            public CreateRoleViewModel(string roleName)
            {
                RoleName = roleName;
            }

            [Required]
            [Display(Name = "Role")]
            public string RoleName { get; set; }
        }
}
