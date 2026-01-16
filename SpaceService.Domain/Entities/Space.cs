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
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}