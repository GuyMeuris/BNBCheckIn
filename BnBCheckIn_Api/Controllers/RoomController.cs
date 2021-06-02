using AutoMapper;
using BNBCheckInServer.Areas.Identity.Pages;
using Business.UnitOfWorkPattern.IUnitOfWorkPattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoomController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
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
                if (!DateTime.TryParseExact(checkInDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckInDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetAllRooms)}");
                    return StatusCode(400, "Date needs to be in format dd/MM/yyyy.");
                }
                if (!DateTime.TryParseExact(checkOutDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetAllRooms)}");
                    return StatusCode(400, "Date needs to be in format dd/MM/yyyy.");
                }

                var allRooms = await _unitOfWork.RoomRepository.GetAll(null, checkInDate, checkOutDate);
                var result = _mapper.Map<IList<RoomDTO>>(allRooms);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetAllRooms)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet("byBnBId")]
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
                if (!DateTime.TryParseExact(checkInDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckInDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomsByBnBId)}");
                    return StatusCode(400, "Date needs to be in format dd/MM/yyyy.");
                }
                if (!DateTime.TryParseExact(checkOutDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckOutDate))
                {
                    Log.Error($"Something went wrong in the {nameof(GetRoomsByBnBId)}");
                    return StatusCode(400, "Date needs to be in format dd/MM/yyyy.");
                }

                var rooms = await _unitOfWork.RoomRepository.GetAll
                        (x => x.BnBId == bnbId, checkInDate, checkOutDate,null,
                                new List<string> { "RoomImages" },
                                           new List<string> { "Amenities" });
                var result = _mapper.Map<IList<RoomDTO>>(rooms);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetRoomsByBnBId)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet("byIsVacant")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRoomsByIsVacant(bool isVacant)
        {
            try
            {
                var rooms = await _unitOfWork.RoomRepository.GetAll
                        (x => x.IsVacant == isVacant, null, null, null,
                                new List<string> { "RoomImages" },
                                            new List<string> { "Amenities" });
                var result = _mapper.Map<IList<RoomDTO>>(rooms);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetRoomsByIsVacant)}");
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

    }
}

