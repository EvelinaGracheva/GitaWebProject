namespace GitaWebProject.Models
{
    public class FilterModel
    {
        public string? Name { get; set; }
        public string? ProductNumber { get; set; }
        public string? Color { get; set; }
        public decimal? ListPrice { get; set; }
        public string? Size { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
    }
}