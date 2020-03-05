using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracking
{

    public enum UserStatus {User, Moderator, Admin};
    public enum ErrorPriority { High, Medium, Low };
    public enum ErrorLevel { Trivial, Insignificant, Significant, Critical, Blocking };

    public class Error
    {

        [Key]
        public int Id { get; set; }
        public DataType Date { get; set; }
        public ErrorPriority Priority { get; set; }
        public ErrorLevel Level { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
    public class Error_Type
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Error> Errors { get; set; }

    }
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

    public class Solution 
    {

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int ErrorId { get; set; }
        [ForeignKey("ErrorId")]
        public virtual Error Error { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
    }

    public class Report 
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int ErrorId { get; set; }
        [ForeignKey("ErrorId")]
        public virtual Error Error { get; set; }
    }
}
