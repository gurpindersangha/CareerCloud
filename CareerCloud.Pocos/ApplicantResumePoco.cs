﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("")]
        public Guid Applicant { get; set; }
        public string Resume { get; set; }
        
        [Column("Last_Updated")]
        public DateTime? LastUpdated { get; set; }
    }
}
