using AutoMapper;
using BNBCheckInServer.Areas.Identity.Pages;
using Business.UnitOfWorkPattern.IUnitOfWorkPattern;
using DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly BnBDbContext _context;
        private readonly IMapper _mapper;

        public RoomController(IUnitOfWork unitOfWork, BnBDbContext context, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllRooms(string checkInDate = null, string checkOutDate = null)
        {
            try
            {
                if (string.IsNullOrEmpty(checkInDate) || string.IsNullOrEmpty(checkOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetAllRooms)}");
                    return StatusCode(400, "All parameters need to be supplied.");
                }
                if (!DateTime.TryParseExact(checkInDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, out var dtCheckInDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetAllRooms)}");
                    return StatusCode(400, "Date needs to be in format dd-MM-yyyy in GetAllRooms.");
                }
                if (!DateTime.TryParseExact(checkOutDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, out var dtCheckOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetAllRooms)}");
                    return StatusCode(400, "Date needs to be in format dd-MM-yyyy in GetAllRooms.");
                }

                var allRooms = await _unitOfWork.RoomRepository.GetAll(null, checkInDate, checkOutDate);
                var result = _mapper.Map<IList<RoomDTO>>(allRooms);

                foreach (RoomDTO roomDTO in result)
                {
                    roomDTO.IsBooked = await IsRoomBooked(roomDTO.RoomId, checkInDate, checkOutDate);
                }
                

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetAllRooms)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet("{roomId:int}", Name ="byRoomId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRoomByRoomId(int roomId, string checkInDate = null, string checkOutDate = null)
        {
            try
            {
                //if (roomId is null)
                //{
                //    Log.Error($"Something went wrong in the {nameof(GetRoomByRoomId)}");
                //    return StatusCode(400, "No room Id was given");
                //}
                if (string.IsNullOrEmpty(checkInDate) || string.IsNullOrEmpty(checkOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomByRoomId)}");
                    return StatusCode(400, "All parameters need to be supplied.");
                }
                if (!DateTime.TryParseExact(checkInDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, 
                            DateTimeStyles.None, out var dtCheckInDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomByRoomId)}");
                    return StatusCode(400, "Date needs to be in format dd-MM-yyyy in GetRoomByRoomId.");
                }
                if (!DateTime.TryParseExact(checkOutDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, 
                            DateTimeStyles.None, out var dtCheckOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomByRoomId)}");
                    return StatusCode(400, "Date needs to be in format dd-MM-yyyy in GetRoomByRoomId.");
                }

                var room = await _unitOfWork.RoomRepository.Get
                        (x => x.RoomId == roomId, checkInDate, checkOutDate,
                                new List<string> { "RoomImages" },
                                           new List<string> { "Amenities" });
                var result = _mapper.Map<RoomDTO>(room);

                result.IsBooked = await IsRoomBooked(roomId, checkInDate, checkOutDate);

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetRoomByRoomId)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet("{bnbId:int}", Name = "byBnBId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRoomsByBnBId(int bnbId, string checkInDate = null, string checkOutDate = null)
        {
            try
            {
                if (string.IsNullOrEmpty(checkInDate) || string.IsNullOrEmpty(checkOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomsByBnBId)}");
                    return StatusCode(400, "All parameters need to be supplied.");
                }
                if (!DateTime.TryParseExact(checkInDate, "dd-MM-yyyy", CultureInfo.InvariantCulture,
                                DateTimeStyles.None, out var dtCheckInDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomsByBnBId)}");
                    return StatusCode(400, "Date needs to be in format dd-MM-yyyy in GetRoomsByBnBId.");
                }
                if (!DateTime.TryParseExact(checkOutDate, "dd-MM-yyyy", CultureInfo.InvariantCulture,
                                DateTimeStyles.None, out var dtCheckOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomsByBnBId)}");
                    return StatusCode(400, "Date needs to be in format dd-MM-yyyy in GetRoomsByBnBId.");
                }
                var rooms = await _unitOfWork.RoomRepository.GetAll
                        (x => x.BnBId == bnbId, checkInDate, checkOutDate,null,
                                new List<string> { "RoomImages" },
                                           new List<string> { "Amenities" });
                var result = _mapper.Map<IList<RoomDTO>>(rooms);

                foreach (RoomDTO roomDTO in result)
                {
                    roomDTO.IsBooked = await IsRoomBooked(roomDTO.RoomId, checkInDate, checkOutDate);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetRoomsByBnBId)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet("byPetsAllowed")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRoomsByPetsAllowed(bool petsAllowed)
        {
            try
            {
                var rooms = await _unitOfWork.RoomRepository.GetAll
                        (x => x.PetsAllowed == petsAllowed, null,null, null,
                                new List<string> { "RoomImages" },
                                           new List<string> { "Amenities" });
                var result = _mapper.Map<IList<RoomDTO>>(rooms);

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetRoomsByPetsAllowed)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        private async Task<bool> IsRoomBooked(int roomId, string checkInDatestr, string checkOutDatestr)
        {
            try
            {
                if (!string.IsNullOrEmpty(checkInDatestr) && !string.IsNullOrEmpty(checkOutDatestr))
                {
                    DateTime checkInDate = DateTime.ParseExact(checkInDatestr, "dd-MM-yyyy", null);
                    DateTime checkOutDate = DateTime.ParseExact(checkOutDatestr, "dd-MM-yyyy", null);

                    var existingBooking = await _context.RoomOrderDetails.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
                    //Check if check-in date that user wants does not fall in between any dates for room that is booked
                    ((checkInDate < x.CheckOutDate && checkInDate.Date >= x.CheckInDate) ||
                    //Check if check-out date that user wants does not fall in between any dates for room that is booked
                    (checkOutDate.Date > x.CheckInDate.Date && checkInDate.Date <= x.CheckInDate)))
                        .FirstOrDefaultAsync();

                    if (existingBooking is not null)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

