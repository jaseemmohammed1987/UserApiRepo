using Microsoft.AspNetCore.Mvc;
using UserApi.Business;
using UserApi.Common.Dto;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUserAsync(int id)
        {
            try
            {
                var result = await _userManager.GetUserAsync(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }

            catch (Exception ex)
            {
                //log exception here
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error fetching user");
            }

        }

        // POST: api/User
        [HttpPost]
        public async Task<ActionResult<UserDto>> PostUserAsync(UserDto user)
        {
            try
            {
                var result = await _userManager.PostUserAsync(user);

                return CreatedAtAction("GetUser", new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                //log exception here
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating user");
            }
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserAsync(int id, UserDto user)
        {
            try 
            {
                if (id != user.Id)
                {
                    return BadRequest();
                }

                var result = await _userManager.GetUserAsync(id);

                if (result == null)
                {
                    return NotFound();
                }

                await _userManager.PutUserAsync(user);

                return NoContent();
            }
            catch (Exception ex)
            {
                //log exception here
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating user");
            }          
        }


    }
}
