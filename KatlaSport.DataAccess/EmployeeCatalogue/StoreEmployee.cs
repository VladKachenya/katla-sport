using System.Collections.Generic;

namespace KatlaSport.DataAccess.EmployeeCatalogue
{
    /// <summary>
    /// Represents a store employee.
    /// </summary>
    public class StoreEmployee
    {
        /// <summary>
        /// Gets or sets an employee ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets an employee first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets an employee last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets an employee email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets an employee photo url.
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Gets or sets an employee place ID.
        /// </summary>
        public int? EmployeePlaceId { get; set; }

        /// <summary>
        /// Gets or sets an employee place.
        /// </summary>
        public virtual EmployeePlace EmployeePlace { get; set; }

        /// <summary>
        /// Gets or sets an employee position ID.
        /// </summary>
        public int EmployeePositionId { get; set; }

        /// <summary>
        /// Gets or sets an employee place.
        /// </summary>
        public virtual EmployeePosition EmployeePosition { get; set; }

        /// <summary>
        /// Gets or sets a boss ID.
        /// </summary>
        public int? BossId { get; set; }

        /// <summary>
        /// Gets or sets a boss.
        /// </summary>
        public virtual StoreEmployee Boss { get; set; }

        /// <summary>
        /// Gets or sets subordinate employees.
        /// </summary>
        public virtual ICollection<StoreEmployee> SubordinateEmployees { get; set; }
    }
}