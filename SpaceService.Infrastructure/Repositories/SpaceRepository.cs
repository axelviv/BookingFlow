using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaceService.Application.Interfaces;
using SpaceService.Domain.Entities;
using SpaceService.Infrastructure.Persistence;

namespace SpaceService.Infrastructure.Repositories
{
    public class SpaceRepository : ISpaceRepository
    {
        private readonly SpaceDbContext _context; 
        public SpaceRepository(SpaceDbContext context)
        { 
            _context = context; 
        } 
        
        public async Task AddAsync(Space space) 
        { 
            _context.Spaces.Add(space);
            await _context.SaveChangesAsync();
        }

        public async Task<Space?> GetByNameAsync(string name) 
        { 
            return await _context.Spaces.FirstOrDefaultAsync(x => x.Name == name); 
        }
    }
}