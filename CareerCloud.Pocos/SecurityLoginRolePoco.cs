using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginRolePoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("")]
        public Guid Login { get; set; }
        
        [ForeignKey("")]
        public Guid Role { get; set; }
        
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }
    }
}
