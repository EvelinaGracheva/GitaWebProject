using GitaWebProject.Data.Entities.Identity;
using GitaWebProject.Interfaces;
using static GitaWebProject.Data.Enum;

namespace GitaWebProject.Data.Entities
{
    public class UserChanges : IEntity<int>, IEntityAudit
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
        public string TableName { get; set; } = null!;
        public OperationType OperationType { get; set; }
        public string Values { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public DateTime OperationDate { get; set; }
    }
}
