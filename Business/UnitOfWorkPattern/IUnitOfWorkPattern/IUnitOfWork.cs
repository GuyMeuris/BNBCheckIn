using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Repository.IRepository.IGenericRepository;

namespace Business.UnitOfWorkPattern.IUnitOfWorkPattern

{
    // We will also use the 'Unit of Work' framework on top of our 'Generic Repository' pattern.
    // This interface will function as a 'ledger' for our generic repository classes, which
    // for the moment are the 'BnB', 'Room', 'Amenity', 'Contact' and the 'Image' datamodel classes.

    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<BnB> BnBRepository { get; }

        IGenericRepository<Room> RoomRepository { get; }

        IGenericRepository<Amenity> AmenityRepository { get; }

        IGenericRepository<Contact> ContactRepository { get; }

        IGenericRepository<Image> ImageRepository { get; }

        Task Save();         // Before this method all the changes will only be staged and not affected yet.
    }
}
