using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        

        [HttpGet]
        public async Task<IActionResult> GetAllRegoins()
        {
            var regions = await regionRepository.GetAllAsync();

            var regionsDTO = mapper.Map<List<Models.DTO.Regoin>>(regions);
            return Ok(regionsDTO );
        }
    }
}
