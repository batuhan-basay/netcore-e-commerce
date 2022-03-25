﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebUl.Identity
{
    public class IdentityDataContext: IdentityDbContext<ApplicationUser>
    {

        public IdentityDataContext() : base("dataConnection")
        {
        }
    }
}