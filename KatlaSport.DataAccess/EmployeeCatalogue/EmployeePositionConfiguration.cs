using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    public class EmployeePositionConfiguration : EntityTypeConfiguration<EmployeePosition>
    {
        public EmployeePositionConfiguration()
        {
            ToTable("employee_position");
            HasKey(i => i.Id);
            Property(i => i.Id).HasColumnName("position_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.Name).HasColumnName("position_name").HasMaxLength(100).IsRequired();
            Property(i => i.Description).HasColumnName("position_description");
        }
    }
}