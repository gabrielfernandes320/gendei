using gendei.Entities;
using gendei.Repositories.contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gendei.Repositories.implementation
{
    public class CityRepository : IGendeiRepository<City>
    {
        readonly gendeiContext _gendeiContext; 
        

        public CityRepository(gendeiContext context)
        {
            _gendeiContext = context;
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            return await _gendeiContext.City.ToListAsync();
        }

        public async Task<City> Get(int id)
        {
            var city = await _gendeiContext.City.FindAsync(id);
            return city;
        }

        public async Task<City> Update(int id, object obj)
        {
            _gendeiContext.Entry(obj).State = EntityState.Modified;

            try
            {
                await _gendeiContext.SaveChangesAsync();
            }
            catch
            {
                throw;
            }

            return await Get(id);

        }

        public bool Exists(int id)
        {
            return _gendeiContext.City.Any(e => e.Id == id);
        }

        public async Task<City> Add(object obj)
        {
            var city = (City) obj;
           

            _gendeiContext.City.Add(city);

            try
            {
                await _gendeiContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return (City)obj;
        }

        public async Task<City> Delete(object obj)
        {
            _gendeiContext.City.Remove((City)obj);

            try
            {
                await _gendeiContext.SaveChangesAsync();
            }
            catch
            {
                throw;
            }

            return (City)obj;
        }

    }
}
