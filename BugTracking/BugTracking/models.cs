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
    public enum ErrorStatus { Open, Closed };

    public class Error
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ErrorStatus ErrorStatus { get; set; }
        public ErrorPriority Priority { get; set; }
        public ErrorLevel Level { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public virtual ErrorType Type { get; set; }
    }
    public class ErrorType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Error> Errors { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MinLength(1)]
        public string Name { get; set; }
        [MinLength(1)]
        public string Surname { get; set; }
        [MinLength(1)]
        public string Login { get; set; }
        [MinLength(1)]
        public string Password { get; set; }
        public UserStatus Status { get; set;}
        [MinLength(1)]
        public string Mail { get; set; }
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        public ICollection<Error> Errors { get; set; }
        public ICollection<Solution> Solutions { get; set; }
        public string Like { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
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
        public int Likes { get; set; }
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
