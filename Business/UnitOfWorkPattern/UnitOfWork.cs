using Business.Repository;
using Business.Repository.IRepository;
using Business.UnitOfWorkPattern.IUnitOfWorkPattern;
using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Repository.IRepository.IGenericRepository;

namespace Business.UnitOfWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        // First we have to introduce a local 'DbContext' using dependency injection
        // from our 'Startup.cs'-file into the constructor here. We will also need 
        // a local object from the two 'IGenericRepository'-classes.
        private readonly BnBDbContext _context;

        private IGenericRepository<BnB> _bnbs;

        private IGenericRepository<Room> _rooms;

        private IGenericRepository<Amenity> _amenities;

        private IGenericRepository<Contact> _contacts;

        private IGenericRepository<RoomImage> _roomimages;
        
        private IGenericRepository<BnBImage> _bnbimages;

        public UnitOfWork(BnBDbContext context)
        {
            _context = context;
        }

        //******************************************************************************
        // Here we will provide a body to the function-headers that were implemented 
        // by inheriting from the interface.

        public IGenericRepository.IGenericRepository<BnB> BnBRepository =>
                                                    _bnbs ??= new GenericRepository<BnB>(_context);

        public IGenericRepository.IGenericRepository<Room> RoomRepository =>
                                                    _rooms ??= new GenericRepository<Room>(_context);

        public IGenericRepository.IGenericRepository<Amenity> AmenityRepository =>
                                                    _amenities ??= new GenericRepository<Amenity>(_context);

        public IGenericRepository.IGenericRepository<Contact> ContactRepository =>
                                                    _contacts ??= new GenericRepository<Contact>(_context);

        public IGenericRepository.IGenericRepository<RoomImage> RoomImageRepository =>
                                                    _roomimages ??= new GenericRepository<RoomImage>(_context);

        public IGenericRepository.IGenericRepository<BnBImage> BnBImageRepository =>
                                                    _bnbimages ??= new GenericRepository<BnBImage>(_context);

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
