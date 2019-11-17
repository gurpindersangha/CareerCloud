using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("")]
        public Guid Login { get; set; }
        
        [Column("Current_Salary")]
        public decimal? CurrentSalary { get; set; }

        [Column("Current_Rate")]
        public decimal? CurrentRate { get; set; }
        
        [Column("Currency")]
        [StringLength(10)]
        public string Currency { get; set; }

        [Column("Country_Code")]
        [ForeignKey("")]
        [StringLength(10)]
        public string CountryCode { get; set; }
        
        [Column("State_Province_Code")]
        [StringLength(10)]
        public string StateProvinceCode { get; set; }
        
        
        [Column("Street_Address")]
        [StringLength(100)]
        public string StreetAddress { get; set; }
        
        [Column("City_Town")]
        [StringLength(100)]
        public string CityTown { get; set; }
        
        
        [Column("Zip_Postal_Code")]
        [StringLength(20)]
        public string ZipPostalCode { get; set; }
        
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }
    }
}
