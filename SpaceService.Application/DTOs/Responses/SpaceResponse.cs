using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaceService.Domain.Enums;

namespace SpaceService.Application.DTOs.Responses
{
    public class SpaceResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SpaceType Type { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}