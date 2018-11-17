using AutoMapper;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;

namespace Collaboo.App.WebAPI.Helpers.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<ProjectRequirement, ProjectRequirementDTO>().ReverseMap();
            CreateMap<Project, AddProjectDTO>().ReverseMap();
            CreateMap<Skill, SkillDTO>().ReverseMap();
            CreateMap<Skill, AddSkillDTO>().ReverseMap();
            CreateMap<UserSkills, UserSkillDTO>()
                .ForMember(target => target.SkillName, map => map.MapFrom(src => src.Skill.SkillName));
            CreateMap<UserSkillDTO, UserSkills>()
                .ForMember(target => target.Skill, map => map.MapFrom(src => new Skill { Id = src.SkillId, SkillName = src.SkillName }));
            CreateMap<AddUserSkillDTO, UserSkills>()
                .ForMember(target => target.Skill, map => map.Ignore());
        }
    }
}