﻿using AutoMapper;
using JobPortal_API.BLL.DTO;
using JobPortal_API.DAL.Repository.Implementation;
using JobPortal_API.DAL.Repository.Interface;
using JobPortal_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IApplicationRepo applicationRepo;

        public ApplicationController(IMapper mapper, IApplicationRepo applicationRepo)
        {
            this.mapper = mapper;
            this.applicationRepo = applicationRepo;
        }

        [HttpPost]

        public async Task<IActionResult> Create([FromBody] AddAplicationRequestDTO addAplicationRequestDTO)
        {
            //Map DTO to Domain Model           
            var ApplicationEntity = mapper.Map<Application>(addAplicationRequestDTO);
            await applicationRepo.CreateAsync(ApplicationEntity);
            //Map domain model to DTO
            var users = mapper.Map<ApplicationDTO>(ApplicationEntity);

            return Ok(users);
        }


        //GET Walks        
        //GET:/api/walks       
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userEntity = await applicationRepo.GetAllAsync();

            return Ok(mapper.Map<List<ApplicationDTO>>(userEntity));
        }

       /*
              [HttpGet]
              [Route("{id:int}")]
              public async Task<IActionResult> GetById([FromRoute] int id)
              {
                  var userEntity = await userRepo.GetByIdAsync(id);
                  if (userEntity == null)
                  {
                      return BadRequest();
                  }
                  var users = mapper.Map<UserDTO>(userEntity);
                  return Ok(users);

              }
        /*
              [HttpPut]
              [Route("{id:int}")]
              public async Task<IActionResult> Update([FromRoute] int id, UpdateUserRequestDTO updateUserRequestDTO)
              {
                  var userEntity = mapper.Map<User>(updateUserRequestDTO);
                  userEntity = await userRepo.UpdateAsync(id, userEntity);
                  if (userEntity == null)
                  {
                      return BadRequest();
                  }
                  var users = mapper.Map<UserDTO>(userEntity);
                  return Ok(users);
              }

              [HttpDelete]
              [Route("{id:int}")]
              public async Task<IActionResult> Delete([FromRoute] int id)
              {
                  var entityDeleted = await userRepo.DeleteAsync(id);
                  if (entityDeleted == null)
                  {
                      return NotFound();
                  }
                  var users = mapper.Map<UserDTO>(entityDeleted);
                  return Ok(users);

              }*/
    }
}
