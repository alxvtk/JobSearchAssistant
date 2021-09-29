using JobSearchAssistantAPI.Contracts;
using JobSearchAssistantAPI.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchAssistantAPI.Services
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(Location entity)
        {
            await _db.Locations.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(Location entity)
        {
            _db.Remove(entity);
            return await Save();
        }

        public async Task<IList<Location>> FindAll()
        {
            var locations = await _db.Locations.Include(q => q.Country).ToListAsync();
            return locations;
        }

        public async Task<Location> FindById(int id)
        {
            var location = await _db.Locations.Include(q => q.Country).FirstOrDefaultAsync(q => q.Id == id);
            return location;
        }

        public async Task<bool> isExists(int id)
        {
            var isExists = await _db.Locations.AnyAsync(q => q.Id == id);
            return isExists;
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<bool> Update(Location entity)
        {
            _db.Locations.Update(entity);
            return await Save();
        }
    }
}
