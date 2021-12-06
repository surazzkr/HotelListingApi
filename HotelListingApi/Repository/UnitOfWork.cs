using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelListingApi.IRepository;
using HotelListingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenricRepository<Country> _countries;
        private IGenricRepository<Hotel> _hotels; 
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenricRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);

        public IGenricRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
