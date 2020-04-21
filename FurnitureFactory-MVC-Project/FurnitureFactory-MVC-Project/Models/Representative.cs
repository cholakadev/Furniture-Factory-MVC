namespace FurnitureFactory_MVC_Project.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Representative
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Email { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
