using System;
using System.ComponentModel.DataAnnotations;

namespace FinalExam.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int QuoteID { get; set; }

        [Required]
        public string Words { get; set; }

        [Required]
        public string Author { get; set; }

        public string Date { get; set; }

        public string Subject { get; set; }

        public string Citation { get; set; }
    }
}
