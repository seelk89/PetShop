using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PetShop.Core.ApplicationService;
using PetShop.Core.Entity;

namespace PetShop.RestAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        readonly IPetShopService _petShopService;

        public PetsController(IPetShopService petShopService)
        {
            _petShopService = petShopService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Pet>> Get()
        {
            return _petShopService.GetPets();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            return _petShopService.PetFoundByIdPreviousOwnerIncluded(id);  
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Pet> Post([FromBody] Pet pet)
        {
            try
            {
                _petShopService.CreatePet(pet);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Pet pet)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            _petShopService.UpdatePet(id, pet);

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            _petShopService.DeletePet(id);

            return Ok();
        }
    }
}
