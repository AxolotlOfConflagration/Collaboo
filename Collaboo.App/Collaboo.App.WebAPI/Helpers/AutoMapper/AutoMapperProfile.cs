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
        }
    }
}