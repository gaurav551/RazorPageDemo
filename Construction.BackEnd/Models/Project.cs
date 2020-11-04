namespace Construction.BackEnd.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Client  { get; set; }
        public string PhotoUrl { get; set; }
    }
}