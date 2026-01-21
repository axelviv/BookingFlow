using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaceService.Application.DTOs.Requests;
using SpaceService.Application.DTOs.Responses;
using SpaceService.Application.Interfaces;
using SpaceService.Domain.Entities;

namespace SpaceService.Application.Handlers.Spaces
{
    public class CreateSpaceHandler
    {
        private readonly ISpaceRepository _repository;

        public CreateSpaceHandler(ISpaceRepository repository) 
        { 
            _repository = repository; 
        }

        public async Task<SpaceResponse> Handle(CreateSpaceRequest request)
        {
            var space = new Space 
            { 
                Id = Guid.NewGuid(), 
                Name = request.Name, 
                Type = request.Type, 
                Description = request.Description, 
                Capacity = request.Capacity, 
                Price = request.Price, 
                CreatedAt = DateTime.UtcNow, 
                UpdatedAt = DateTime.UtcNow 
            };

            await _repository.AddAsync(space);

            return new SpaceResponse 
            { 
                Id = space.Id, 
                Name = space.Name, 
                Type = space.Type, 
                Description = space.Description, 
                Capacity = space.Capacity, 
                Price = space.Price, 
                CreatedAt = space.CreatedAt, 
                UpdatedAt = space.UpdatedAt 
            };
        }         
    }
}