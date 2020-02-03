using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("")]
        public Guid Login { get; set; }
        
        [ForeignKey("")]
        public Guid Role { get; set; }
        
        [Column("Time_Stamp")]
        [NotMapped]
        public byte[] TimeStamp { get; set; }
        public virtual SecurityLoginPoco SecurityLogin { get; set; }
        public virtual SecurityRolePoco SecurityRole { get; set; }
    }
}
