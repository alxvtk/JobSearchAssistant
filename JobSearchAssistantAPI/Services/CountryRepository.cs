﻿using JobSearchAssistantAPI.Contracts;
using JobSearchAssistantAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchAssistantAPI.Services
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _db;

        public CountryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(Country entity)
        {
            await _db.Countries.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(Country entity)
        {
            _db.Countries.Remove(entity);
            return await Save();
        }

        public async Task<IList<Country>> FindAll()
        {
            var countries = await _db.Countries.ToListAsync();
            //var countries = await _db.Countries.Include(q => q.Locations).ToListAsync();
            return countries;
        }

        public async Task<Country> FindById(int id)
        {
            var country = await _db.Countries.FindAsync(id);
            //var country = await _db.Countries.Include(q => q.Locations).FirstOrDefaultAsync(q => q.Id == id);
            return country;
        }

        public async Task<bool> isExists(int id)
        {
            return await _db.Countries.AnyAsync(q => q.Id == id);
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<bool> Update(Country entity)
        {
            _db.Countries.Update(entity);
            return await Save();
        }
    }
}
