using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatlaSport.Services.HiveManagement
{
    /// <summary>
    /// Represents a hive service.
    /// </summary>
    public interface IHiveService
    {
        /// <summary>
        /// Gets a hives list async.
        /// </summary>
        /// <returns>A <see cref="Task{List{HiveListItem}}"/>.</returns>
        Task<List<HiveListItem>> GetHivesAsync();

        /// <summary>
        /// Gets a hive with specified identifier async.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <returns>A <see cref="Task{Hive}"/>.</returns>
        Task<Hive> GetHiveAsync(int hiveId);

        /// <summary>
        /// Creates a new hive async.
        /// </summary>
        /// <param name="createRequest">A <see cref="UpdateHiveRequest"/>.</param>
        /// <returns>A <see cref="Task{Hive}"/>.</returns>
        Task<Hive> CreateHiveAsync(UpdateHiveRequest createRequest);

        /// <summary>
        /// Updates an existed hive async.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <param name="updateRequest">A <see cref="UpdateHiveRequest"/>.</param>
        /// <returns>A <see cref="Task{Hive}"/>.</returns>
        Task<Hive> UpdateHiveAsync(int hiveId, UpdateHiveRequest updateRequest);

        /// <summary>
        /// Deletes an existed hive async.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task DeleteHiveAsync(int hiveId);

        /// <summary>
        /// Sets deleted status for a hive async.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <param name="deletedStatus">Status.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task SetStatusAsync(int hiveId, bool deletedStatus);
    }
}
