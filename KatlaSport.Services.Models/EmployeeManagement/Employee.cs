namespace KatlaSport.Services.EmployeeManagement
{
    /// <summary>
    /// Represents an employee.
    /// </summary>
    public class Employee : EmployeeListItem
    {
        /// <summary>
        /// Gets or sets an employee position.
        /// </summary>
        public string WorkPlaceAddress { get; set; }

        /// <summary>
        /// Gets or sets an employee photo url.
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Gets or sets an employee email.
        /// </summary>
        public string Email { get; set; }
    }
}