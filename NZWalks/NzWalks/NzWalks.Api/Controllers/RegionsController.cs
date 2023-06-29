using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NzWalks.Api.CustomActionFilters;
using NzWalks.Api.Data;
using NzWalks.Api.Models.Domain;
using NzWalks.Api.Models.DTO;
using NzWalks.Api.Repositories;

namespace NzWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(NZWalksDbContext dbContext, IRegionRepository regionRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            //Get Data From Database - Domain models 
            var regionsDomain = await regionRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<RegionDto>>(regionsDomain));
        }

        //Get Region by Id
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<ActionResult> GetById([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.Find(id);
            //Get Region Domain Model From Database

            var regionDomain = await regionRepository.GetByIdAsync(id);

            if (regionDomain == null)
            {
                return NotFound();
            }

            //Map Region Domain Model to Region Dto
            //Return Dto back to client 
            return Ok(mapper.Map<RegionDto>(regionDomain));
        }

        //Create New Region
        [HttpPost]
        [ValidateModel]
        public async Task<ActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            //Map the Dto to Domain Model
            var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);

            //Use DomainModel to create the Region
            regionDomainModel = await regionRepository.CreateAsync(regionDomainModel);

            //map domain model back to dto
            var regionDto = mapper.Map<RegionDto>(regionDomainModel);

            return CreatedAtAction(nameof(GetById), new { id = regionDto.Id }, regionDto);
        }

        //Update region
        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]

        public async Task<ActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            //Map Dto to domain model 
            var regionDomainModel = mapper.Map<Region>(updateRegionRequestDto);

            //check if region exists
            regionDomainModel = await regionRepository.UpdateAsync(id, regionDomainModel);

            if (regionDomainModel == null)
            {
                return NotFound();
            }

            //Convert Domain Model to Dto
            return Ok(mapper.Map<RegionDto>(regionDomainModel));
        }

        //This is to Delete a Region
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> Delete([FromRoute] Guid id)
        {
            var regionDomanModel = await regionRepository.DeleteAsync(id);

            if (regionDomanModel == null)
            {
                return NotFound();
            }

            //Map Domain Model to Dto
            return Ok(mapper.Map<RegionDto>(regionDomanModel));

        }
    }
}
