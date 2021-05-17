using AutoMapper;
using BNBCheckInServer.ServerRepository.IServerRepository;
using Business.UnitOfWorkPattern.IUnitOfWorkPattern;
using DataAccess.Data;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNBCheckInServer.ServerRepository
{
    public class RoomRepository : IRoomRepository
    {
        // First we need to include our 'IUnitOfWork'-object and
        // 'IMapper'-object using depency injection.
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;  // Needed to map to our CompanyDTO's

        public RoomRepository(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).
        // We use the 'Generic Repository Pattern' with the 'UnityOfWork' framework on top,
        // that we already created for our data models.

        public async Task<RoomDTO> CreateRoom(CreateRoomDTO roomDTO)
        {
            Room room = _mapper.Map<CreateRoomDTO, Room>(roomDTO);
            room.CreatedDate = DateTime.Now;
            room.CreatedBy = "";
            await _unitOfWork.RoomRepository.Create(room);
            await _unitOfWork.Save();
            return _mapper.Map<Room, RoomDTO>(room);
        }

        public async Task<IList<RoomDTO>> GetAllRooms()
        {
            try
            {
                var rooms = await _unitOfWork.RoomRepository.GetAll();
                IList<RoomDTO> roomDTOs = _mapper.Map<IList<Room>, IList<RoomDTO>> (rooms);
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
                var room = await _unitOfWork.RoomRepository.Get(x => x.RoomId == roomId);
                RoomDTO roomDTO = _mapper.Map<Room, RoomDTO>(room);
                return roomDTO;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The room failed to load when invoking the 'GetRoom'-method.");
                return null;
            }
        }

        // If unique returns null, else returns the room object
        public async Task<RoomDTO> UpdateRoom(int roomId, RoomDTO roomDTO)
        {
            try
            {
                if (roomId == roomDTO.RoomId)
                {
                    //valid
                    Room roomDetails = await _unitOfWork.RoomRepository.Get(x => x.RoomId == roomId);
                    Room room = _mapper.Map<RoomDTO, Room>(roomDTO, roomDetails);
                    room.UpdatedDate = DateTime.Now;
                    room.UpdatedBy = "";
                    _unitOfWork.RoomRepository.Update(room);
                    await _unitOfWork.Save();
                    return _mapper.Map<Room, RoomDTO>(room);
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
            Room roomDetails = await _unitOfWork.RoomRepository.Get(x => x.RoomId == roomId);
            if (roomDetails is not null)
            {
                await _unitOfWork.RoomRepository.Delete(roomId);
                return await _unitOfWork.SaveOnDelete();
                
            }
            return 0;
        }

        public async Task<RoomDTO> IsRoomUnique(string name)
        {
            try
            {
                var room = await _unitOfWork.RoomRepository.Get(x => x.RoomName.ToLower() == name.ToLower());
                RoomDTO roomDTO = _mapper.Map<Room, RoomDTO>(room);
                return roomDTO;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occured when invoking the 'IsRoomUnique'-method.");
                return null;
            }
        }
    }
}
