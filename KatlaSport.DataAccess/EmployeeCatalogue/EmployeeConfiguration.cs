using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("employee_records");
            HasKey(i => i.Id);
            HasRequired(i => i.Boss).WithMany(i => i.SubordinateEmployees).HasForeignKey(i => i.BossId);
            HasRequired(i => i.EmployeePlace).WithMany(i => i.Employees).HasForeignKey(i => i.EmployeePlaceId);
            HasRequired(i => i.EmployeePosition).WithMany(i => i.Employees).HasForeignKey(i => i.EmployeePositionId);
            Property(i => i.Id).HasColumnName("employee_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.FirstName).HasColumnName("employee_first_name").HasMaxLength(60).IsRequired();
            Property(i => i.LastName).HasColumnName("employee_last_name").HasMaxLength(60).IsRequired();
            Property(i => i.Email).HasColumnName("employee_email").HasMaxLength(60).IsRequired();
            Property(i => i.PhotoUrl).HasColumnName("employee_photo_url");
            Property(i => i.EmployeePlaceId).HasColumnName("employee_place_id").IsOptional();
            Property(i => i.EmployeePositionId).HasColumnName("employee_position_id");
            Property(i => i.BossId).HasColumnName("employee_boss_id").IsOptional();
        }
    }
}