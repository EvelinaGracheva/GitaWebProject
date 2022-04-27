using static GitaWebProject.Data.Enum;

namespace GitaWebProject.Models
{
    public class UserChangesModel
    {
        public string TableName { get; set; } = null!;
        public OperationType OperationType { get; set; }
        public string Values { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public DateTime OperationDate { get; set; }
    }
}
