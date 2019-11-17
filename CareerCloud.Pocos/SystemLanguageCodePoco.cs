using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("System_Language_Codes")]
    public class SystemLanguageCodePoco
    {
        [Key]
        [StringLength(10)]
        public string LanguageID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        [Column("Native_Name")]
        public string NativeName { get; set; }
    }
}
