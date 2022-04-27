using GitaWebProject.Data.Entities.Identity;

namespace GitaWebProject.Interfaces
{
    public interface IEntityAudit
    {
        DateTime CreatedAt { get; set; }

        DateTime? ModifiedAt { get; set; }

        DateTime? DeletedAt { get; set; }

        Guid CreatedById { get; set; }

        User? CreatedBy { get; set; }

        Guid? ModifiedById { get; set; }

        User? ModifiedBy { get; set; }

        Guid? DeletedById { get; set; }

        User? DeletedBy { get; set; }
    }
}
