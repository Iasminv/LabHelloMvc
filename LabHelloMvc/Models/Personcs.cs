using System.ComponentModel.DataAnnotations;

namespace LabHelloMvc.Models
{
    public class Person
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }


    }
}
