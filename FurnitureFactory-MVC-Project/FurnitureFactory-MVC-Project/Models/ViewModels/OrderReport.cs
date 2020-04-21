namespace FurnitureFactory_MVC_Project.Models.ViewModels
{
    using System;

    public class OrderReport
    {
        public string OrderNumber { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
