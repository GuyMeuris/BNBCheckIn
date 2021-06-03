﻿using AutoMapper;
using Business.Repository.IRepository;
using Common;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class RoomOrderDetailsRepository : IRoomOrderDetailsRepository
    {
        // First we need to include our 'BnBDbContext'-object and
        // 'IMapper'-object using depency injection.
        private readonly BnBDbContext _context;

        private readonly IMapper _mapper;

        public RoomOrderDetailsRepository(BnBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<RoomOrderDetailsDTO> Create(CreateRoomOrderDetailsDTO createDetailsDTO)
        {
            try
            {
                createDetailsDTO.CheckInDate = createDetailsDTO.CheckInDate.Date;
                createDetailsDTO.CheckOutDate = createDetailsDTO.CheckOutDate.Date;
                var roomOrder = _mapper.Map<CreateRoomOrderDetailsDTO, RoomOrderDetails>(createDetailsDTO);
                roomOrder.OrderStatus = BookingStatusCodes.Status_Pending;
                var result = await _context.RoomOrderDetails.AddAsync(roomOrder);
                await _context.SaveChangesAsync();
                return _mapper.Map<RoomOrderDetails, RoomOrderDetailsDTO>(result.Entity);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The room order details were not created when invoking the 'Create'-method.");
                return null;
            }
        }

        public async Task<IEnumerable<RoomOrderDetailsDTO>> GetAllRoomOrderDetails()
        {
            try
            {
                IEnumerable<RoomOrderDetailsDTO> roomOrders = _mapper.Map<IEnumerable<RoomOrderDetails>, IEnumerable<RoomOrderDetailsDTO>>
                    (_context.RoomOrderDetails.Include(u => u.BnBRoom));
                return roomOrders;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The room order details failed to load when invoking the 'GetAllRoomOrderDetails'-method.");
                return null;
            }
        }

        public async Task<RoomOrderDetailsDTO> GetRoomOrderDetails(int roomOrderId)
        {
            try
            {
                RoomOrderDetails roomOrder = await _context.RoomOrderDetails
                        .Include(u => u.BnBRoom).ThenInclude(x => x.RoomImages)
                                .FirstOrDefaultAsync(u => u.OrderId == roomOrderId);
                RoomOrderDetailsDTO roomOrderDetailsDTO = _mapper.Map<RoomOrderDetails, RoomOrderDetailsDTO>(roomOrder);
                roomOrderDetailsDTO.BnBRoomDTO.TotalDays = roomOrderDetailsDTO.CheckOutDate.Subtract(roomOrderDetailsDTO.CheckInDate).Days;
                return roomOrderDetailsDTO;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The room order details failed to load when invoking the 'GetRoomOrderDetails'-method.");
                return null;
            }
        }

        public async Task<bool> IsRoomBooked(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            var status = false;
            var existingBooking = await _context.RoomOrderDetails.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
            //Check if check-in date that user wants does not fall in between any dates for room that is booked
            (checkInDate < x.CheckOutDate && checkInDate.Date > x.CheckInDate) ||
            //Check if check-out date that user wants does not fall in between any dates for room that is booked
            (checkOutDate.Date > x.CheckInDate.Date && checkInDate.Date < x.CheckInDate))
                .FirstOrDefaultAsync();

            if (existingBooking is not null)
            {
                status = true;
            }
            return status;
        }

        public Task<RoomOrderDetailsDTO> MarkPaymentSuccessful(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderStatus(int roomOrderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}