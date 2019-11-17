﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [Column("Registration_Date")]
        public DateTime RegistrationDate { get; set; }
        
        [Column("Company_Website")]
        [StringLength(100)]
        public string  CompanyWebsite{ get; set; }
        
        
        [Column("Contact_Phone")]
        [StringLength(20)]
        public string  ContactPhone { get; set; }
        
        
        [Column("Contact_Name")]
        [StringLength(50)]
        public string  ContactName { get; set; }
        
        
        [Column("Company_Logo")]
        public byte[]  CompanyLogo { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }

    }
}
