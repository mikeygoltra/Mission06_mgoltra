using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
      
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [Range(0, 25, ErrorMessage = "Notes can be no longer than 25 characters.")]
        public string Notes { get; set; }

        //Build Foreign Key Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
