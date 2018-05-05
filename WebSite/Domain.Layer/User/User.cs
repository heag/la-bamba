using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Layer.User
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name must be maximum 50 characters")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;
    }

}
