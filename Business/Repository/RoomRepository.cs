using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class RoomRepository : IRoomRepository
    {
        
        // First we need to include our 'BnBDbContext'-object and
        // 'IMapper'-object using depency injection.
        private readonly BnBDbContext _context;

        private readonly IMapper _mapper;

        public RoomRepository(BnBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<RoomDTO> CreateRoom(RoomDTO roomDTO)
        {
            Room room = _mapper.Map<RoomDTO, Room>(roomDTO);
            room.CreatedDate = DateTime.Now;
            room.CreatedBy = "";
            var addedRoom = await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
            return _mapper.Map<Room, RoomDTO>(addedRoom.Entity);
        }

        public async Task<IEnumerable<RoomDTO>> GetAllRooms()
        {
            try
            {
                IEnumerable<RoomDTO> roomDTOs = _mapper.Map<IEnumerable<Room>, IEnumerable<RoomDTO>>
                    (_context.Rooms.Include(x => x.Images));
                return roomDTOs;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The rooms failed to load when invoking the 'GetAll'-method.");
                return null;
            }
        }

        public async Task<RoomDTO> GetRoom(int roomId)
        {
            try
            {
                RoomDTO room = _mapper.Map < Room, RoomDTO>(
                      await _context.Rooms.Include(x => x.Images).FirstOrDefaultAsync(x => x.RoomId == roomId));
                return room;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The room failed to load when invoking the 'GetRoom'-method.");
                return null;
            }
        }

        public async Task<RoomDTO> UpdateRoom(int roomId, RoomDTO roomDTO)
        {
            try
            {
                if (roomId == roomDTO.RoomId)
                {
                    //valid
                    Room roomDetails = await _context.Rooms.FindAsync(roomId);
                    Room room = _mapper.Map<RoomDTO, Room>(roomDTO, roomDetails);
                    room.UpdatedDate = DateTime.Now;
                    room.UpdatedBy = "";
                    var updatedRoom = _context.Rooms.Update(room);
                    await _context.SaveChangesAsync();
                    return _mapper.Map<Room, RoomDTO>(updatedRoom.Entity);
                }
                else
                {
                    //invalid
                    Log.Error("'roomId' does not match 'roomDTO.RoomId' when invoking the 'UdateRoom'-method.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The room failed to update when invoking the 'UpdateRoom'-method.");
                return null;
            }
        }

        public async Task<int> DeleteRoom(int roomId)
        {
            var roomDetails = await _context.Rooms.FindAsync(roomId);
            if (roomDetails is not null)
            {
                var allImages = await _context.Images.Where(x => x.RoomId == roomId).ToListAsync();
                _context.Images.RemoveRange(allImages);

                _context.Rooms.Remove(roomDetails);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        // If unique returns null else returns the room obj
        public async Task<RoomDTO> IsRoomUnique(string name, int roomId = 0)
        {
            try
            {
                if (roomId == 0)
                {
                    RoomDTO room = _mapper.Map<Room, RoomDTO>(
                      await _context.Rooms.FirstOrDefaultAsync(x => x.RoomName.ToLower() == name.ToLower()));
                    return room;
                }
                else
                {
                    RoomDTO room = _mapper.Map<Room, RoomDTO>(
                      await _context.Rooms.FirstOrDefaultAsync(x => x.RoomName.ToLower() == name.ToLower()
                      && x.RoomId != roomId));
                    return room;
                }              
            }
            catch (Exception)
            {
                return null;
            }
        }

        
    }
}
