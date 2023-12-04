using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsManager.Server.Domain.Entities;
using StudentsManager.Server.Presentation.Models.Student;
using StudentsManager.Server.Services.Interfaces;

namespace StudentsManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService StudentsService;
        private readonly IMapper Mapper;

        public StudentsController(IStudentsService studentsService, IMapper mapper) 
        {
            StudentsService = studentsService;
            Mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<StudentModel> Get()
        {
            var students = StudentsService.Get().Include(s => s.Group).ToList();
            return Mapper.Map<IEnumerable<StudentModel>>(students);
        }

        [HttpPost]
        public async Task Post([FromBody] StudentCreateModel student)
        {
            var mappedStudent = Mapper.Map<Student>(student);
            await StudentsService.Create(mappedStudent);
        }

        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] StudentModel student)
        {
            var mappedStudent = Mapper.Map<Student>(student);
            await StudentsService.Update(mappedStudent);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await StudentsService.Delete(id);
        }
    }
}
