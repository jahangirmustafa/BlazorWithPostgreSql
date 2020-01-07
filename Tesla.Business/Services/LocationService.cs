using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesla.Data;
using Tesla.Data.Entities;

namespace Tesla.Business.Services
{
    public interface ILocationService
    {
        Task<List<Location>> GetLocationAsync();
        Task<Location> AddLocationAsync();
    }


    public class LocationService : ILocationService
    {
        private readonly ApplicationContext _context;

        public LocationService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Location>> GetLocationAsync()
        {
            return await _context.Locations.ToListAsync();

        }

        public async Task<Location> AddLocationAsync()
        {
            var location = new Location {
                Id = Guid.NewGuid(),
                Address = "Johar",
                City = "Lahore",
                Country = "Pak",
                State = "Punjab"
            };

            var result = await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();

            return result.Entity;

        }
    }
}
