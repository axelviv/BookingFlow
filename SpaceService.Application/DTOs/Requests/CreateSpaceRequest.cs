using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaceService.Domain.Enums;

namespace SpaceService.Application.DTOs.Requests
{
    public class CreateSpaceRequest
    {
        public string Name { get; set; } = string.Empty;
        public SpaceType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public decimal Price { get; set; }
    }
}