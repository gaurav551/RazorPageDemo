using System;

namespace Construction.BackEnd.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirement { get; set; }
        public DateTime PostedOn { get; set; } = DateTime.Now;
    }
}