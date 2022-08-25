using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]   // will take default controller name
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
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            //return DTO regions

            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Name = region.Name,
            //        Code = region.Code,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,
                  
            //    };
            //    regionsDTO.Add(regionDTO);
            //});

            var regionsDTO=mapper.Map<List<Models.DTO.Region>>(regions);
            return Ok(regionsDTO);


            /*
            var regions = new List<Region>
            {
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Wellington",
                    Code="Well",
                    Lat=1.3543,
                    Long=4.234,
                    Population=345345
                },
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Auckland",
                    Code="Auck",
                    Lat=1.3543,
                    Long=4.234,
                    Population=345345
                }
            };
            */

        }
    }
}
