using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Service.Mapping
{
    public class MapProfile:Profile
    {
       public MapProfile()
        {
            CreateMap<Personal, PersonalDto>().ReverseMap();
            CreateMap<Personal, PersonalWithProjetsDto>();

            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<Project, ProjectWithDetailDto>();
            CreateMap<ApprovalStatus, Enum>().ReverseMap();


        }
    }
}
