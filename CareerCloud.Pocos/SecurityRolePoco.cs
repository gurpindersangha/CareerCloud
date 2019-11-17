﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Security_Roles")]
    public class SecurityRolePoco
    {
        [Key]
        public Guid Id { get; set; }
        
        [StringLength(50)]
        public string Role { get; set; }
        
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }
    }
}
