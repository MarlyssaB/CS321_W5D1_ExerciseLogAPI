using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W5D1_ExerciseLogAPI.Core.Models
{  // inherit from IdentityUser in Identity framework
    public class AppUser : IdentityUser
    {
        // NOTE that there is no Id property. 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Activity> Activities { get; set; }
        // other app specific properties
    }
}
