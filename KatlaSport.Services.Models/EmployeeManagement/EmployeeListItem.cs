namespace KatlaSport.Services.EmployeeManagement
{
    /// <summary>
    /// Represents an employee list item.
    /// </summary>
    public class EmployeeListItem
    {
        /// <summary>
        /// Gets or sets an employee ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets an employee full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets an employee position.
        /// </summary>
        public string Position { get; set; }
    }
}