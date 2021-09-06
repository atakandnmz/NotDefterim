using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NotDefterim.Data
{
    public class ApplicationUser:IdentityUser
    {
        public DateTime RegistrationTime { get; set; } = DateTime.Now;
        public List<Note> Notes { get; set; }
    }
}
