using TaskManager.Core.Interfaces;
using TaskManager.Core.Models;

namespace TaskManager.Core.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IHttpClientCommandHandler _httpCommandHandler;
        private readonly string baseUrl = "https://632e2a882cfd5ccc2afcfab2.mockapi.io/api/v1/TaskManager/TaskManager";
        public TaskRepository(IHttpClientCommandHandler httpCommandHandler)
        {
            _httpCommandHandler = httpCommandHandler;
        }

        /// <summary>
        /// Get all task using httpClientCommandHandler
        /// </summary>
        /// <returns>IEnumerable of tasklist</returns>
        public async Task<IQueryable<TaskList>> GetAllTasksAsync()
        {
            return await _httpCommandHandler.GetRequest<IQueryable<TaskList>>(baseUrl);
        }

        /// <summary>
        /// Get task by Id using The base Url and the Id of the task
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>A tasklist</returns>
        public async Task<TaskList> GetTaskByIdAsync(string Id)
        {
            string url = $"{baseUrl}/{Id}";
            return await _httpCommandHandler.GetRequest<TaskList>(url);
        }

        /// <summary>
        /// Creates task 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>A tasklist</returns>
        public async Task<TaskList> AddTaskAsync(TaskList data)
        {
            return await _httpCommandHandler.PostRequest<TaskList, TaskList>(data, baseUrl);
        }

        /// <summary>
        /// Delete task using the base url and the Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteAsync(string Id)
        {
            string url = $"{baseUrl}/{Id}";
            await _httpCommandHandler.DeleteRequest<TaskList>(url);
            return true;
        }
    }
}
