using System.ComponentModel.DataAnnotations;

namespace GitaWebProject.Models
{
    public class ProductCreateModel
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "ProductNumber Is Required")]
        [StringLength(25, ErrorMessage = "ProductNumber cannot be longer than 25 characters")]
        public string ProductNumber { get; set; } = null!;

        [Required(ErrorMessage = "MakeFlag Is Required")]
        public bool MakeFlag { get; set; }
        
        [Required(ErrorMessage = "FinishedGoodsFlag Is Required")]
        public bool FinishedGoodsFlag { get; set; }

        [StringLength(15, ErrorMessage = "Color cannot be longer than 15 characters")]
        public string? Color { get; set; }

        [Required(ErrorMessage = "SafetyStockLevel Is Required")]
        public int SafetyStockLevel { get; set; }

        [Required(ErrorMessage = "ReorderPoint Is Required")]
        public int ReorderPoint { get; set; }

        [Required(ErrorMessage = "StandardCost Is Required")]
        public decimal StandardCost { get; set; }

        [Required(ErrorMessage = "ListPrice Is Required")]
        public decimal ListPrice { get; set; }

        [StringLength(5, ErrorMessage = "Color cannot be longer than 5 characters")]
        public string? Size { get; set; }

        public decimal? Weight { get; set; }

        [Required(ErrorMessage = "DaysToManufacture Is Required")]
        public int DaysToManufacture { get; set; }

        [StringLength(2, ErrorMessage = "Color cannot be longer than 2 characters")]
        public string? ProductLine { get; set; }

        [StringLength(2, ErrorMessage = "Color cannot be longer than 2 characters")]
        public string? Class { get; set; }
        
        [StringLength(2, ErrorMessage = "Color cannot be longer than 2 characters")]
        public string? Style { get; set; }
        
        [Required(ErrorMessage = "SellStartDate Is Required")]
        public DateTime SellStartDate { get; set; }
        
        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }
        
        [Required(ErrorMessage = "Rowguid Is Required")]
        public Guid Rowguid { get; set; }

        [Required(ErrorMessage = "ModifiedDate Is Required")]
        public DateTime ModifiedDate { get; set; }
    }
}
