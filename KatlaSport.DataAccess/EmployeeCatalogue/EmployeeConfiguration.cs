using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    public class EmployeeConfiguration : EntityTypeConfiguration<StoreEmployee>
    {
        public EmployeeConfiguration()
        {
            ToTable("employee_records");
            HasKey(i => i.Id);
            HasOptional(i => i.Boss).WithMany(i => i.SubordinateEmployees).HasForeignKey(i => i.BossId);
            HasOptional(i => i.EmployeePlace).WithMany(i => i.Employees).HasForeignKey(i => i.EmployeePlaceId);
            HasRequired(i => i.EmployeePosition).WithMany(i => i.Employees).HasForeignKey(i => i.EmployeePositionId);
            Property(i => i.Id).HasColumnName("employee_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.FirstName).HasColumnName("employee_first_name").HasMaxLength(60).IsRequired();
            Property(i => i.LastName).HasColumnName("employee_last_name").HasMaxLength(60).IsRequired();
            Property(i => i.Email).HasColumnName("employee_email").HasMaxLength(60).IsRequired();
            Property(i => i.PhotoUrl).HasColumnName("employee_photo_url");
            Property(i => i.BossId).HasColumnName("employee_boss_id").IsOptional();
            Property(i => i.EmployeePlaceId).HasColumnName("employee_place_id").IsOptional();
            Property(i => i.EmployeePositionId).HasColumnName("employee_position_id").IsRequired();
            Property(i => i.IsDeleted).HasColumnName("deleted").IsRequired();
            Property(i => i.CreatedBy).HasColumnName("created_by_id").IsRequired();
            Property(i => i.Created).HasColumnName("created_utc").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(i => i.LastUpdatedBy).HasColumnName("updated_by_id").IsRequired();
            Property(i => i.LastUpdated).HasColumnName("updated_utc").IsRequired();
        }
    }
}