using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentsManager.Server.Presentation.Models.StudentsGroup;
using StudentsManager.Server.Services.Interfaces;

namespace StudentsManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsGroupsController : ControllerBase
    {
        private readonly IStudentsGroupsService StudentsGroupsService;
        private readonly IMapper Mapper;

        public StudentsGroupsController(IStudentsGroupsService studentsGroupsService, IMapper mapper)
        {
            StudentsGroupsService = studentsGroupsService;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentsGroupModel>> Get()
        {
            var groups = await StudentsGroupsService.Get();
            return Mapper.Map<IEnumerable<StudentsGroupModel>>(groups);
        }
    }
}
