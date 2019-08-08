namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    internal sealed class EmployeeCatalogueContext : DomainContextBase<ApplicationDbContext>, IEmployeeCatalogueContext
    {
        public EmployeeCatalogueContext(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEntitySet<StoreEmployee> Employees => GetDbSet<StoreEmployee>();

        public IEntitySet<EmployeePlace> Places => GetDbSet<EmployeePlace>();

        public IEntitySet<EmployeePosition> Positions => GetDbSet<EmployeePosition>();
    }
}