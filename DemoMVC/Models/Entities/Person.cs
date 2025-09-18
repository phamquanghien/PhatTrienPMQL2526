using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class Person
    {
        [Key]
        public string StudentID { get; set; } = default!;
        public string FullName { get; set; } = default!;
    }
}