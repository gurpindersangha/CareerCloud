using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("")]
        public Guid Job { get; set; }
        
        [StringLength(100)]
        public string Skill { get; set; }
        
        [Column("Skill_Level")]
        [StringLength(10)]
        public string SkillLevel { get; set; }
       
        public int Importance { get; set; }

        [Column("Time_Stamp")]
        [NotMapped]
        public byte[] TimeStamp { get; set; }
        public virtual CompanyJobPoco CompanyJob { get; set; }


    }
}
