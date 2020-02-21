using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BugTracking
{
    class models
    {
        enum ErrorPriority { High, Medium, Low };
        enum ErrorLevel { Trivial, Insignificant, Significant, Critical, Blocking};

        public class Error 
        {

            [Key]
            public int Id { get; set; }
            public DataType Date { get; set; }
            public ErrorPriority Priority { get; set; }
            public ErrorLevel Level { get; set; }
            public string Code { get; set; }
            public string Description{ get; set; }
            public int UserId { get; set; }
            [ForeignKey("UserId")]
            public virtual User User { get; set; }

        }
        public class Error_Type 
        {

            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Error> Errors { get;set; }

        }
    }
}
