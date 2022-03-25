using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web;

namespace MvcWebUl.Identity
{
    public class ApplicationRole: IdentityUser
    {
        public string Name { get; set; }
        public string Description{ get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string rolename, string description)
        {
            this.Description = description;
        }
    }
}