using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace FineHouseService.DataObjects
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }


        public string LastName { get; set; }


        public byte Level { get; set; }


        public DateTime JoinDate { get; set; }

    }
}

