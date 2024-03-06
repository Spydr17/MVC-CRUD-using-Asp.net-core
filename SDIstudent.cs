using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appmvc.Models
{
    public class SDIstudent
    {
        internal object Students;

        [Key]
        public int id { get; set; }
        [Column("studName", TypeName="Varchar(100)")]
        [Required]
        public string studName { get; set; }
        [Column("studTrade", TypeName = "Varchar(10)")]
        public string Trade { get; set; }
        [Column("Course", TypeName = "Varchar(10)")]
        public string Course { get; set; }
        public string skills { get; set; }
        public string language_known { get; set; }
    }
}
