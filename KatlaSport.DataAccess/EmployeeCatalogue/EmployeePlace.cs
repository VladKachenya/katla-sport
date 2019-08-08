using System.Collections.Generic;

namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    /// <summary>
    /// Represents an employee place of work.
    /// </summary>
    public class EmployeePlace
    {
        /// <summary>
        /// Gets or sets an employee place ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets an employee work place county.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets an employee work place city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets an employee work place street.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets an employee work place house number.
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets an employee assigned to this place.
        /// </summary>
        public virtual ICollection<StoreEmployee> Employees { get; set; }
    }
}