using AutoMapper;
using Business.UnitOfWorkPattern.IUnitOfWorkPattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> GetAllRooms()
        {
            try
            {
                var allRooms = await _unitOfWork.RoomRepository.GetAll();
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
        public async Task<IActionResult> GetRoomsByBnBId(int bnbId)
        {
            try
            {
                var rooms = await _unitOfWork.RoomRepository.GetAll
                        (x => x.BnBId == bnbId, null,
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
                        (x => x.IsVacant == isVacant, null,
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
                        (x => x.PetsAllowed == petsAllowed, null,
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

