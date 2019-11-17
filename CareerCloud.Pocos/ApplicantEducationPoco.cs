using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    public class ApplicantEducationPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [ForeignKey("")]
        public Guid Applicant { get; set; }

        [StringLength(100)]
        public string Major { get; set; }

        [Column("Certificate_Diploma")]
        [StringLength(100)]
        public string CertificateDiploma { get; set; }

        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }

        [Column("Compilation_Date")]
        public DateTime? CompilationDate { get; set; }

        [Column("Completion_Percent")]
        public byte? CompletionPercent { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }


    }
}
