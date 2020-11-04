using System.ComponentModel.DataAnnotations;

namespace Construction.BackEnd.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
         [MinLength(5)]
        public string Designation { get; set; }
        public string PhotoUrl { get; set; }
    }
}