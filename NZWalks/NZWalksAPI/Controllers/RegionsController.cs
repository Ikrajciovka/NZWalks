using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Models.Domain;
using NZWalksAPI.Repositories;

namespace NZWalksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionsRepository;
        private readonly IMapper Mapper;

        public RegionsController(IRegionRepository regionsRepository, IMapper mapper)
        {
            this.regionsRepository = regionsRepository;
            this.Mapper = mapper;
        }

        [HttpGet]
       public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionsRepository.GetAllAsync();
            var regionsDTO = Mapper.Map<List<Models.DTOs.Region>>(regions);
            return Ok(regionsDTO);
        }
    }
}
