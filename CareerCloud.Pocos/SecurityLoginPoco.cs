using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    public class SecurityLoginPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [StringLength(50)]
        public string Login { get; set; }
        
        [StringLength(100)]
        public string Password { get; set; }
        
        [Column("Created_Date")]
        public DateTime CreatedDate { get; set; }
        
        
        [Column("Password_Update_Date")]
        public DateTime? PasswordUpdateDate { get; set; }
        
        
        [Column("Agreement_Accepted_Date")]
        public DateTime? AgreementAcceptedDate { get; set; }
        
        
        [Column("Is_Locked")]
        public bool IsLocked { get; set; }
        
        
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }
        
        
        [Column("Email_Address")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        
        
        [Column("Phone_Number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        
        
        [Column("Full_Name")]
        [StringLength(100)]
        public string FullName { get; set; }
        
        
        [Column("Force_Change_Password")]
        public bool ForceChangePassword { get; set; }
        
        
        [Column("Prefferred_Language")]
        [StringLength(10)]
        public string PrefferredLanguage { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }
    }
}
