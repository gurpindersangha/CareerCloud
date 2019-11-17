using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("")]
        public Guid Applicant { get; set; }
        
        [Column("Company_Name")]
        [StringLength(150)]
        public string CompanyName { get; set; }
        
        [Column("Country_Code")]
        [ForeignKey("")]
        public string CountryCode { get; set; }
        
        [StringLength(50)]
        public string Location { get; set; }
        
        [Column("Job_Title")]
        [StringLength(50)]
        public string JobTitle { get; set; }
        
        [Column("Job_Description")]
        [StringLength(500)]
        public string JobDescription { get; set; }
        
        [Column("Start_Month")]
        public short StartMonth { get; set; }
        
        [Column("Start_Year")]
        public int StartYear { get; set; }
        
        [Column("End_Month")]
        public short EndMonth { get; set; }
        
        [Column("End_Year")]
        public int EndYear { get; set; }
        
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }

    }
}
