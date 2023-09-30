using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.API.Controllers;
using TaskManager.Core.Interfaces;
using TaskManager.Core.Services;

namespace TaskManager.Test
{
    public class GetAllTaskTest
    {
        public class BooksControllerTest
        {
            TasksController _controller;
            ITaskService _service;

            public BooksControllerTest()
            {
                _service = new TaskService();
                _controller = new TasksController(_service);

            }

            [Fact]
            public void GetAllTest()
            {
                //Arrange
                //Act
                var result = _controller.GetAllTasks();
                //Assert
                Assert.IsType<OkObjectResult>(result.Result);

                var list = result.Result as OkObjectResult;

                Assert.IsType<IEnumerable<Core.DTO.TaskListDTO>>(list.Value);



                var listBooks = list.Value as List<Core.DTO.TaskListDTO>;

                Assert.Equal(31, listBooks.Count);
            }
        }
    }
}
