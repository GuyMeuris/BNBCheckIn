using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using Business.UnitOfWorkPattern;
using Business.UnitOfWorkPattern.IUnitOfWorkPattern;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsDTO;
using Serilog;

namespace BnBCheckIn_Api.Controllers
{
    [Route("api/[controller]")]
    public class BnBController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BnBController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllBnBs()
        {
            try
            {
                var allBnBs = await _unitOfWork.BnBRepository.GetAll();
                var result = _mapper.Map<IList<BnBDTO>>(allBnBs);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetAllBnBs)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBnBByProvince(string province)
        {
            try
            {
                    var bnbs = await _unitOfWork.BnBRepository.GetAll(x => x.Province == province, 
                        null, new List<string> { "Rooms"}, 
                                new List<string> { "BnBImages" }, new List<string> { "Amenities" });
                    var result = _mapper.Map<IList<BnBDTO>>(bnbs);
                    return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Something went wrong in the {nameof(GetBnBByProvince)}");
                return StatusCode(500, "Internal server error, please try again later.");
            }
        }

    }
}
