using System.ComponentModel.DataAnnotations;

namespace GitaWebProject.Models
{
    public class ProductUpdateModel
    {
        public int ProductID { get; set; }

        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string? Name { get; set; }

        [StringLength(25, ErrorMessage = "ProductNumber cannot be longer than 25 characters")]
        public string? ProductNumber { get; set; }

        public bool? MakeFlag { get; set; }

        public bool? FinishedGoodsFlag { get; set; }

        [StringLength(15, ErrorMessage = "Color cannot be longer than 15 characters")]
        public string? Color { get; set; }

        public short? SafetyStockLevel { get; set; }

        public short? ReorderPoint { get; set; }

        public decimal? StandardCost { get; set; }

        public decimal? ListPrice { get; set; }

        [StringLength(5, ErrorMessage = "Color cannot be longer than 5 characters")]
        public string? Size { get; set; }

        public decimal? Weight { get; set; }

        public int? DaysToManufacture { get; set; }

        public string? ProductLine { get; set; }

        public string? Class { get; set; }

        [StringLength(2, ErrorMessage = "Color cannot be longer than 2 characters")]
        public string? Style { get; set; }

        public DateTime? SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        public Guid? Rowguid { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
