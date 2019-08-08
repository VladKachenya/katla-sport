using System.Collections.Generic;

namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    public class EmployeePosition
    {
        /// <summary>
        /// Gets or sets an employee position ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets an employee position name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an employee position description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets an employee assigned to this position.
        /// </summary>
        public virtual ICollection<StoreEmployee> Employees { get; set; }
    }
}