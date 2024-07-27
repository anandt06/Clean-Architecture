namespace CleanArchitecture.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
    }
}