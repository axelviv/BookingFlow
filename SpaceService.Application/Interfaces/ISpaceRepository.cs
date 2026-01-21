using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaceService.Domain.Entities;

namespace SpaceService.Application.Interfaces
{
    public interface ISpaceRepository
    {
        Task AddAsync(Space space); 
        Task<Space?> GetByNameAsync(string name);
    }
}