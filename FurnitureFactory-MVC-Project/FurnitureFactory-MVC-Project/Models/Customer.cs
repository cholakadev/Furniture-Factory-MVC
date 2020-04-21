namespace FurnitureFactory_MVC_Project.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(10)]
        public string CompanyNumber { get; set; }

        public Representative Representative { get; set; }

        public List<Order> Orders { get; set; }
    }
}
