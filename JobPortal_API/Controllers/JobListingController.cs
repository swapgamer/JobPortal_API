using AutoMapper;
using JobPortal_API.BLL.DTO;
using JobPortal_API.DAL.Repository.Interface;
using JobPortal_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobListingController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IJobListingRepo jobListingRepo;

        //Creating Constructor
        public JobListingController(IMapper mapper, IJobListingRepo jobListingRepo)
        {
            this.mapper = mapper;
            this.jobListingRepo = jobListingRepo;
        }

          
        [HttpPost]

        public async Task<IActionResult> Create([FromBody] AddJobListingRequestDTO addJobListingRequestDTO)
        {
           //Map DTO to domain Model          
            var userEntity = mapper.Map<JobListing>(addJobListingRequestDTO);
            await jobListingRepo.CreateAsync(userEntity);
            //Domain Model to DTO
            var users = mapper.Map<JobListingDTO>(userEntity);

            return Ok(users);
        }

             
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userEntity = await jobListingRepo.GetAllAsync();

            return Ok(mapper.Map<List<JobListingDTO>>(userEntity));
        }

       [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var userEntity = await jobListingRepo.GetByIdAsync(id);
            if (userEntity == null)
            {
                return BadRequest();
            }
            var users = mapper.Map<JobListingDTO>(userEntity);
            return Ok(users);

        }

       [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, UpdateJobListingDTO updateJobListingDTO)
        {
            var userEntity = mapper.Map<JobListing>(updateJobListingDTO);
            userEntity = await jobListingRepo.UpdateAsync(id, userEntity);
            if (userEntity == null)
            {
                return BadRequest();
            }
            var users = mapper.Map<JobListingDTO>(userEntity);
            return Ok(users);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var entityDeleted = await jobListingRepo.DeleteAsync(id);
            if (entityDeleted == null)
            {
                return NotFound();
            }
          
            return Ok("Deleted");
        }

    }
}
        
    

