using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using SpaceService.Domain.Enums;

namespace SpaceService.Domain.Entities
{
    public class Space
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public SpaceType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;
    }
}