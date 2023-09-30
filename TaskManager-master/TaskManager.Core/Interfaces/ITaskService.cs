using TaskManager.Core.DTO;
using TaskManager.Core.Models;

namespace TaskManager.Core.Interfaces
{
    public interface ITaskService
    {
        Task<TaskList> AddTaskAsync(CreateTaskDTO data);
        Task<string> DeleteAsync(string Id);
        Task<IEnumerable<TaskListDTO>> GetAllTasksAsync();
        Task<TaskListDTO> GetTaskByIdAsync(string Id);
    }
}