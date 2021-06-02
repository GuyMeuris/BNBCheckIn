using AutoMapper;
using Business.UnitOfWorkPattern.IUnitOfWorkPattern;
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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AmenityController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AmenityController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllAmenities()
        {
            try
            {
                var allAmenities = await _unitOfWork.AmenityRepository.GetAll();
                var result = _mapper.Map<IList<AmenityDTO>>(allAmenities);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetAllAmenities)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet("{id:int}", Name = "byBnBId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAmenityByBnBId(int? bnbId)
        {
            try
            {
                if (bnbId is null)
                {
                    Log.Error($"Something went wrong in the {nameof(GetAmenityByBnBId)}");
                    return StatusCode(400, "No room Id was given");
                }
                var amenities = await _unitOfWork.AmenityRepository.Get(x => x.BnBs.All(b => b.BnBId == bnbId));
                var result = _mapper.Map<IList<AmenityDTO>>(amenities);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetAmenityByBnBId)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet("{id:int}", Name = "byRoomId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAmenityByRoomId(int? roomId)
        {
            try
            {
                if (roomId is null)
                {
                    Log.Error($"Something went wrong in the {nameof(GetAmenityByRoomId)}");
                    return StatusCode(400, "No room Id was given");
                }
                var amenities = await _unitOfWork.AmenityRepository.Get(x => x.Rooms.All(b => b.RoomId == roomId));
                var result = _mapper.Map<IList<AmenityDTO>>(amenities);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetAmenityByRoomId)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }
    }
}
