using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.DTOs;
using TaskManager.Core.Models;

namespace TaskManager.Core.Utilities.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<TaskList, TaskListDTO>().ReverseMap();
            CreateMap<TaskList, CreateTaskDTO>().ReverseMap();
        }

    }
}
