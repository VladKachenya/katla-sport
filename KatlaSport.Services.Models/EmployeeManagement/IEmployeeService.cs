using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatlaSport.Services.EmployeeManagement
{
    /// <summary>
    /// Represents a employee service.
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Gets an employees list async.
        /// </summary>
        /// <param name="start">A start.</param>
        /// <param name="amount">An amount.</param>
        /// <returns>A <see cref="Task{List{EmployeeListItem}}"/>.</returns>
        Task<List<EmployeeListItem>> GetEmployeesAsync(int start, int amount);

        /// <summary>
        /// Gets an subordinate employees list async.
        /// </summary>
        /// <param name="start">A start.</param>
        /// <param name="amount">An amount.</param>
        /// <param name="bossId">An boss id.</param>
        /// <returns>A <see cref="Task{List{EmployeeListItem}}"/>.</returns>
        Task<List<EmployeeListItem>> GetSubordinateEmployeesAsync(int start, int amount, int bossId);

        /// <summary>
        /// Gets an employee with specified identifier.
        /// </summary>
        /// <param name="employeeId">An employee identifier.</param>
        /// <returns>A <see cref="Task{Employee}"/>.</returns>
        Task<Employee> GetEmployeeAsync(int employeeId);

        /// <summary>
        /// Creates a new employee async.
        /// </summary>
        /// <param name="createRequest">A <see cref="UpdateEmployeeRequest"/>.</param>
        /// <returns>A <see cref="Task{Employee}"/>.</returns>
        Task<Employee> CreateEmployeeAsync(UpdateEmployeeRequest createRequest);

        /// <summary>
        /// Sets deleted status for a hive async.
        /// </summary>
        /// <param name="employeeId">A hive identifier.</param>
        /// <param name="deletedStatus">Status.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task SetStatusAsync(int employeeId, bool deletedStatus);
    }
}