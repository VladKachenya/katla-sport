using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    public class EmployeePlaceConfiguration : EntityTypeConfiguration<EmployeePlace>
    {
        public EmployeePlaceConfiguration()
        {
            ToTable("employee_work_places");
            HasKey(i => i.Id);
            Property(i => i.Id).HasColumnName("place_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.Country).HasColumnName("place_country").HasMaxLength(60).IsRequired();
            Property(i => i.City).HasColumnName("place_city").HasMaxLength(60).IsRequired();
            Property(i => i.Street).HasColumnName("place_street").HasMaxLength(60).IsRequired();
            Property(i => i.HouseNumber).HasColumnName("place_house").HasMaxLength(60).IsRequired();
        }
    }
}