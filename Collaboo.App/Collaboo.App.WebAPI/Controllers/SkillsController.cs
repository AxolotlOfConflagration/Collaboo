using AutoMapper;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Controllers
{
    [Route("api/skills")]
    public class SkillsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISkillsServices _skillsServices;

        public SkillsController(IMapper mapper, ISkillsServices skillsServices)
        {
            _mapper = mapper;
            _skillsServices = skillsServices;
        }

        [HttpPost]
        public async Task<IActionResult> AddSkill([FromBody] AddSkillDTO skill)
        {
            var dbSkill = _mapper.Map<Skill>(skill);
            await _skillsServices.AddSkill(dbSkill);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetSkill(int id)
        {
            var skill = _skillsServices.GetSkill(id);
            return Ok(_mapper.Map<SkillDTO>(skill));
        }

        [HttpGet]
        public IActionResult GetSkills()
        {
            var skills = _skillsServices.GetSkills();
            return Ok(_mapper.Map<IEnumerable<SkillDTO>>(skills));
        }
    }
}
