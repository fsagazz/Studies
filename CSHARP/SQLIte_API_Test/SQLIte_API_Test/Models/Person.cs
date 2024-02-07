using System.ComponentModel.DataAnnotations;

namespace SQLIte_API_Test.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
