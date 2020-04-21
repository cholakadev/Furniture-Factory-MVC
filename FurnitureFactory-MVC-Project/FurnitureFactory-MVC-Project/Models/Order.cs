namespace FurnitureFactory_MVC_Project.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string OrderNumber { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int ArticleId { get; set; }

        public Article Article { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
