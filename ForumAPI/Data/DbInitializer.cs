using ForumAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ForumContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

