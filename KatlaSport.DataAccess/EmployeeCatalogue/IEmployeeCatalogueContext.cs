namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    /// <summary>
    /// Represents a context for employee catalogue domain.
    /// </summary>
    public interface IEmployeeCatalogueContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Gets a set of <see cref="Employee"/> entities.
        /// </summary>
        IEntitySet<Employee> Employees { get; }

        /// <summary>
        /// Gets a set of <see cref="EmployeePlace"/> entities.
        /// </summary>
        IEntitySet<EmployeePlace> Places { get; }

        /// <summary>
        /// Gets a set of <see cref="EmployeePosition"/> entities.
        /// </summary>
        IEntitySet<EmployeePosition> Positions { get; }
    }
}