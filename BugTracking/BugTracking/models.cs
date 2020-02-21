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
        public class Solution {

            [Key]
            public int Id { get; set; }
            public string Description { get; set; }
            public int ErrorId { get; set; }
            [ForeignKey("ErrorId")]
            public virtual Error Error { get; set; }
            public int UserID { get; set; }
            [ForeignKey("UserId")]
            public virtual User User { get; set; }
            public DateTime Date { get; set; }
        }

        public class Report {
            [Key]
            public int Id { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
            public int ErrorId { get; set; }
            [ForeignKey("ErrorId")]
            public virtual Error Error { get; set; }       
        }
    }
}
