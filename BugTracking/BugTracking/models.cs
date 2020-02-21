using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.

namespace BugTracking
{
    class models
    {
        enum UserStatus {User, Moderator, Admin};
        public class User
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public UserStatus Status { get; set;}
            public string Mail { get; set; }
            public int PhoneNumber { get; set; }

        }
    }
}
