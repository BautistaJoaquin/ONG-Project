﻿using OngProject.Application.Mappings;
using OngProject.Domain.Entities;

namespace OngProject.Application.DTOs.Organizations
{
    public class GetOrganizationPublicDto : IMapFrom<Organization>
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}