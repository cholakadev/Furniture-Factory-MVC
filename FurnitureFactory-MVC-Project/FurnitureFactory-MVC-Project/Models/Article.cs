namespace FurnitureFactory_MVC_Project.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Article
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public double Weight { get; set; }

        public decimal Price { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
