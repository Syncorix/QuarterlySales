﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuarterlySales.Models
{
    public class User : IdentityUser
    {
        // TODO: later we'll add our app-specific props here
        [NotMapped]
        public IList<string> RoleNames { get; set; }

    }
}
