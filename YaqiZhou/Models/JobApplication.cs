namespace YaqiZhou.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class JobApplication
    {
        public int Id { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; }

        [Required]
        public string Status { get; set; }

        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }

        public IdentityUser User { get; set; }
    }
}
