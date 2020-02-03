using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("")]
        public Guid Company { get; set; }

        [StringLength(10)]
        [ForeignKey("")]
        public string LanguageId { get; set; }

        [Column("Company_Name")]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(1000)]
        [Column("Company_Description")]
        public string CompanyDescription { get; set; }

        [Column("Time_Stamp")]
        [NotMapped]
        public byte[] TimeStamp { get; set; }
        public virtual CompanyProfilePoco CompanyProfile { get; set; }
        public virtual SystemLanguageCodePoco SystemLanguageCode { get; set; }
    }
}
