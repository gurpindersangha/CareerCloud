using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
    public class CompanyJobDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("")]
        public Guid Job { get; set; }
        
        [Column("Job_Name")]
        [StringLength(100)]
        public string JobName { get; set; }
        
        [Column("Job_Descriptions")]
        [StringLength(1000)]
        public string JobDescriptions { get; set; }
        
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }
    }
}
