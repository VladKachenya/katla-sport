namespace KatlaSport.Services.EmployeeManagement
{
    /// <summary>
    /// Represents a request for creating and updating a employee.
    /// </summary>
    public class UpdateEmployeeRequest
    {
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
        /// Gets or sets an employee position ID.
        /// </summary>
        public int EmployeePositionId { get; set; }

        /// <summary>
        /// Gets or sets an employee place ID.
        /// </summary>
        public int? EmployeePlaceId { get; set; }

        /// <summary>
        /// Gets or sets a boss ID.
        /// </summary>
        public int? BossId { get; set; }
    }
}