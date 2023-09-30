using AutoMapper;
using Microsoft.Extensions.Logging;
using TaskManager.Core.DTO;
using TaskManager.Core.Interfaces;
using TaskManager.Core.Models;

namespace TaskManager.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TaskService> _logger;
        public TaskService()
        {

        }
        public TaskService(ITaskRepository taskRepository, IMapper mapper, ILogger<TaskService> logger)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
            _logger = logger;
        }
        
        /// <summary>
        /// Get all task
        /// </summary>
        /// <returns>IEnumerable of task</returns>
        public async Task<IEnumerable<TaskListDTO>> GetAllTasksAsync()
        {
            var tasks = await _taskRepository.GetAllTasksAsync();
            var response = _mapper.Map<IEnumerable<TaskListDTO>>(tasks);
            if (response == null)
            {
                _logger.LogError($"Error occuried getting from database");
                return new List<TaskListDTO>();
    
            }
            foreach (var task in response)
            {
                task.DueDate = task.StartDate.AddDays(task.AllottedTimeInDays);
                task.EndDate = task.StartDate.AddDays(task.ElapsedTimeInDays);
                task.DaysOverDue = !task.TaskStatus ? (task.ElapsedTimeInDays - task.AllottedTimeInDays) : 0;
                task.DaysLate = task.TaskStatus ? (task.AllottedTimeInDays - task.ElapsedTimeInDays) : 0;
                _logger.LogInformation("getting all task");
            }
            return response;
        }

        /// <summary>
        /// Get all task
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>A TasklistDto</returns>
        public async Task<TaskListDTO> GetTaskByIdAsync(string Id)
        {
            var tasks = await _taskRepository.GetTaskByIdAsync(Id);
            var task = _mapper.Map<TaskListDTO>(tasks);
            task.DueDate = task.StartDate.AddDays(task.AllottedTimeInDays);
            task.EndDate = task.StartDate.AddDays(task.ElapsedTimeInDays);
            task.DaysOverDue = !task.TaskStatus ? (task.ElapsedTimeInDays - task.AllottedTimeInDays) : 0;
            task.DaysLate = task.TaskStatus ? (task.AllottedTimeInDays - task.ElapsedTimeInDays) : 0;
            _logger.LogInformation($"Task with Id {Id} successfully fetched");
            return task;
            
        }

        /// <summary>
        /// Add or Create new task
        /// </summary>
        /// <param name="data"></param>
        /// <returns>A Taklist</returns>
        public async Task<TaskList> AddTaskAsync(CreateTaskDTO data)
        {
            var model = _mapper.Map<TaskList>(data);
            model.StartDate = DateTime.Now;
            var result = await _taskRepository.AddTaskAsync(model);
           _logger.LogInformation("Task successflly added");
            return result;
        }

        /// <summary>
        /// Delete task by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>A string</returns>
        public async Task<string> DeleteAsync(string Id)
        {
            var result = await _taskRepository.DeleteAsync(Id);
             _logger.LogInformation("Task successflly deleted");
            if (!result)
            {
                return "Item not successfully deleted";
            }
            return $"Item with Id {Id} successfully deleted";
        }
    }
}
