using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaceService.Domain.Enums;

namespace SpaceService.Application.DTOs.Requests
{
    public class UpdateSpaceRequest
    {
        public string Name { get; set; }
        public SpaceType Type { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
    }
}