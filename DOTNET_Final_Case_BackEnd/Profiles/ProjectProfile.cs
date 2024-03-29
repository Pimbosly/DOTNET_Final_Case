﻿using AutoMapper;
using DOTNET_Final_Case_BackEnd.DTOs.ProjectDTO;
using DOTNET_Final_Case_BackEnd.Models;

namespace DOTNET_Final_Case_BackEnd.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {

            // Mapping from the domain object to the readDTO object.
            CreateMap<Project, ProjectReadDTO>();

            // Mapping from the createDTO object to the domain object. ReverseMap is for navigating both ways.
            CreateMap<ProjectCreateDTO, Project>().ReverseMap();

            // Mapping from the createDTO object to the domain object. ReverseMap is for navigating both ways.
            CreateMap<ProjectUpdateDTO, Project>().ReverseMap();

            // Mapping from the domain object to the deleteDTO object.
            CreateMap<Project, ProjectDeleteDTO>();

        }

    }
}
