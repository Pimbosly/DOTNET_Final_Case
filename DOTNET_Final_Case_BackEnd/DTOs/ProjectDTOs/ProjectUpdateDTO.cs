﻿using System.ComponentModel.DataAnnotations;

namespace DOTNET_Final_Case_BackEnd.DTOs.ProjectDTO
{
    public class ProjectUpdateDTO
    {
        // Prperties of the DTO.

        public int ProjectId { get; set; }
        [MaxLength(60)] public string Title { get; set; }

        [MaxLength(500)] public string? Description { get; set; }

        [MaxLength(60)] public string? Theme { get; set; }

        [MaxLength(60)] public string Industry { get; set; }

        [MaxLength(500)] public string? Link { get; set; }

        [MaxLength(500)] public string? Photo { get; set; }

        [MaxLength(60)] public string? Progress { get; set; }
    }
}
