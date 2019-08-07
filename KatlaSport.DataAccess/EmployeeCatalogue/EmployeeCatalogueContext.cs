namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    internal sealed class EmployeeCatalogueContext : DomainContextBase<ApplicationDbContext>, IEmployeeCatalogueContext
    {
        public EmployeeCatalogueContext(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEntitySet<Employee> Employees => GetDbSet<Employee>();

        public IEntitySet<EmployeePlace> Places => GetDbSet<EmployeePlace>();

        public IEntitySet<EmployeePosition> Positions => GetDbSet<EmployeePosition>();
    }
}