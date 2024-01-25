namespace WebAPIDapper.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Address { get; set; }
        public required string MobileNumber { get; set; }
    }
}