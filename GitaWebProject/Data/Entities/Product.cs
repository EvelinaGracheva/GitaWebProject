using GitaWebProject.Data.Entities.Identity;
using GitaWebProject.Interfaces;

namespace GitaWebProject.Data.Entities
{
    public class Product : IEntity<int>, IEntityAudit
    {
        #region Interface Implementations

        public int Id { get; set; }


        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Guid CreatedById { get; set; }

        public virtual User? CreatedBy { get; set; }

        public Guid? ModifiedById { get; set; }

        public virtual User? ModifiedBy { get; set; }

        public Guid? DeletedById { get; set; }

        public virtual User? DeletedBy { get; set; }


        #endregion
        public int ProductID { get; set; }
        public string Name { get; set; } = null!;
        public string ProductNumber { get; set; } = null!;
        public bool MakeFlag { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        public string? Color { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string? Size { get; set; }
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string? ProductLine { get; set; }
        public string? Class { get; set; }
        public string? Style { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
