using JobSearchAssistantAPI.Contracts;
using JobSearchAssistantAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchAssistantAPI.Services
{
    public class BusinessRepository : IBusinessRepository
    {
        private readonly ApplicationDbContext _db;

        public BusinessRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(Business entity)
        {
            await _db.Businesses.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(Business entity)
        {
            _db.Businesses.Remove(entity);
            return await Save();
        }

        public async Task<IList<Business>> FindAll()
        {
            var businesses = await _db.Businesses.ToListAsync();
            return businesses;
        }

        public async Task<Business> FindById(int id)
        {
            var business = await _db.Businesses.FindAsync(id);
            return business;
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<bool> Update(Business entity)
        {
            _db.Businesses.Update(entity);
            return await Save();
        }
    }
}
