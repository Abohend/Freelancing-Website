﻿using AutoMapper;
using src.Models;
using src.Models.Dto;
using src.Models.Dto.Category;
using src.Models.Dto.Client;
using src.Models.Dto.Freelancer;
using src.Models.Dto.Project;
using src.Models.Dto.ProjectProposal;

namespace src
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterClientDto, Client>()
                .ForMember(des => des.UserName, opt => opt.MapFrom(src => src.Email));
            CreateMap<RegisterFreelancerDto, Freelancer>()
                .ForMember(des => des.UserName, opt => opt.MapFrom(src => src.Email));

            CreateMap<Client, GetClientDto>()
                .ForMember(des => des.ImageUrl, opt => opt.MapFrom(src => src.ImagePath))
                .ForMember(des => des.ProjectsId, opt => opt.MapFrom(src => src.Projects!.Select(p => p.Id)));
            CreateMap<UpdateClientDto, Client>();

            CreateMap<Freelancer, GetFreelancerDto>()
                .ForMember(des => des.ImageUrl, opt => opt.MapFrom(src => src.ImagePath))
                .ForMember(des => des.ProjectsId, opt => opt.MapFrom(src => src.Projects!.Select(p => p.Id)));
            CreateMap<UpdateFreelancerDto, Freelancer>();

            CreateMap<CreateCategoryDto, Category>();
            CreateMap<Category, GetCategoryDto>();

			CreateMap<Skill, SkillDto>().ReverseMap();

			CreateMap<Client, UserDto>();
            CreateMap<Project, GetProjectDto>();
            CreateMap<CreateProjectDto, Project>();

            CreateMap<CreateProjectProposalDto, ProjectProposal>();
            CreateMap<ProjectProposal, ReadProjectProposal>();
        }

    }
}
