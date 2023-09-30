using AutoMapper;
using TaskManager.Core.DTO;
using TaskManager.Core.Models;

namespace TaskManager.Core.Utilities.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskList, TaskListDTO>().ReverseMap();
            CreateMap<TaskList, CreateTaskDTO>().ReverseMap();
        }
    }
}
