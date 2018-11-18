using AutoMapper;
using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;

namespace Collaboo.App.WebAPI.Helpers.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>()
                .ForMember(db => db.Avatar, map => map.MapFrom(dto => dto.AvatarUrl))
                .ForMember(db => db.UserSkills, map => map.MapFrom(dto => dto.Skills))
                //.ForMember(db => db.Login, map => map.MapFrom(dto => dto.Login))
                //.ForMember(db => db.GitHubId, map => map.MapFrom(dto => dto.GitHubId))
                //.ForMember(db => db.Id, map => map.MapFrom(dto => dto.Id))
                .ReverseMap();
            CreateMap<User, UserDTO>()
                .ForMember(dto => dto.AvatarUrl, map => map.MapFrom(db => db.Avatar))
                .ForMember(dto => dto.Skills, map => map.MapFrom(db => db.UserSkills))
                //.ForMember(dto => dto.Login, map => map.MapFrom(db => db.Login))
                //.ForMember(dto => dto.GitHubId, map => map.MapFrom(db => db.GitHubId))
                //.ForMember(dto => dto.Id, map => map.MapFrom(db => db.Id))
                .ReverseMap();
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