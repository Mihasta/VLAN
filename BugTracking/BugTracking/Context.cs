using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BugTracking
{
    public class BTContext : DbContext
    {
        public BTContext() : base("BTContext")
        {
        }

    }
}
