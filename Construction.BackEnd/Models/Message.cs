using System;
using System.ComponentModel.DataAnnotations;

namespace Construction.BackEnd.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Subject Required")]
        public string Subject { get; set; }
         [Required(ErrorMessage="Description Required")]
         [MinLength(10,ErrorMessage="Message is not enough")]
         [MaxLength(500)]

        public string Description { get; set; }
        [Required(ErrorMessage="Name Required")]
         

        public string SenderName { get; set; }
        public DateTime SentOn { get; set; } = DateTime.Now;
        [Required(ErrorMessage="Email Required")]
        [DataType(DataType.EmailAddress)]
        public string SenderEmail { get; set; }
        [Required(ErrorMessage="Phone Required")]
        public string SenderPhone { get; set; }
        public string FilePath { get; set; }
    }
}