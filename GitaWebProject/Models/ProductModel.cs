using System.ComponentModel.DataAnnotations;

namespace GitaWebProject.Models
{
    public class ProductModel
    {
        [Required]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string ProductNumber { get; set; } = null!;

        [Required]
        public bool MakeFlag { get; set; }

        [Required]
        public bool FinishedGoodsFlag { get; set; }

        public string? Color { get; set; }

        [Required]
        public int SafetyStockLevel { get; set; }

        [Required]
        public int ReorderPoint { get; set; }

        [Required]
        public decimal StandardCost { get; set; }

        [Required]
        public decimal ListPrice { get; set; }

        public string? Size { get; set; }

        public decimal? Weight { get; set; }

        [Required]
        public int DaysToManufacture { get; set; }

        public string? ProductLine { get; set; }

        public string? Class { get; set; }

        public string? Style { get; set; }

        [Required]
        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        [Required]
        public Guid Rowguid { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
