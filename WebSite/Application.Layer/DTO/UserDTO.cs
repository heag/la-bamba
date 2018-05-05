using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.Layer.DTO
{
    public class UserDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

}
