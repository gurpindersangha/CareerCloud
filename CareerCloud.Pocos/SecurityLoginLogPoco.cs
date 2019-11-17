using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Log")]
    public class SecurityLoginLogPoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("")]
        public Guid Login { get; set; }
        
        [Column("Source_Ip")]
        [StringLength(15)]
        public string SourceIp { get; set; }
        
        
        [Column("Logon_Date")]
        public DateTime LogonDate { get; set; }
        
        
        [Column("Is_Succesful")]
        public bool IsSuccesful { get; set; }
    }
}
