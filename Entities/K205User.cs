using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class K205User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
