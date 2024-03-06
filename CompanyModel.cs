using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appmvc.Models
{
    public class CompanyModel
    {
        [Key]
        public int Sl_No { get; set; }
        [Column("CompanyName", TypeName ="Varchar(100)")]
        public string CompanyName { get; set; }
        [Column("CompanyEmail", TypeName ="Varchar(50)")]
        public string CompanyEmail  { get; set;}
        public int CompanyPhone { get; set;}
        public string requirement { get; set; }
    }
}
