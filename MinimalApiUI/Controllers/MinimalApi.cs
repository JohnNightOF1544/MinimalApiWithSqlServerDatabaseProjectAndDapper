using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinimalApiUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinimalApi : ControllerBase
    {
        private readonly IPersonData _data;

        public MinimalApi(IPersonData data)
        {
            _data = data;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<PersonModel> results = await _data.GetPerson();

            if (results is null)
                return NotFound( new
                {
                    success = false,
                    message = "No data in the database.",
                });

            if (results is not null)
                return Ok(new
                {
                    success = true,
                    message = "Here are the list of user",
                    data = results
                });
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            PersonModel result = await _data.GetPerson(id);

            if (result is null)
                return NotFound(new
                { 
                    success = false, 
                    message = "No data found in the database." 
                });

            if (result is not null)
                return Ok(new
                {
                    success = true,
                    message = "Here is the person.",
                    data = result
                });

            return NoContent();


        }

        [HttpPost]
        public async Task<IActionResult> Add(PersonModel person)
        {
            if (person is null) 
                return BadRequest( new
                {
                    success = false,
                    message = "Please input all fields."
                });
            
            if (person is not null)
            {
                await _data.AddPerson(person);
                return CreatedAtAction("GetById", new { id = person.Id }, person);
            }
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(PersonModel person)
        {
            if (person == null)
                return BadRequest(new
                {
                    success = false,
                    message = "Error while updating."
                });

            if (person != null)
            {
                await _data.UpdatePerson(person);
                return Ok(new
                {
                    success = true,
                    message = "Successfully update.",
                });
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return NotFound(new
                {
                    success = false,
                    message = "Error while deleting the data."
                });

            if (id != 0)
            {
                await _data.DeletePerson(id);
                return Ok(new
                {
                    success = true,
                    message = "Deleted Successfully",
                });
            }

            return NoContent();
        }




    }
}
