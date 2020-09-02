using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gendei.Models;
using gendei.Repositories.contract;
using gendei.Repositories.implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gendei.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IGendeiRepository<User> _userRepository;

        public UsersController(IGendeiRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        
        [HttpGet]
        public async Task<object> GetAllUsers()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            try
            {
                var user = await _userRepository.Get(id);
                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(new {message = "Error to find user", exception = e.Message, innerExeption = e.InnerException?.Message});
            }
           
        }

      
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUserAsync(int id, User user)
        {
            try
            {
                if (id != user.Id)
                {
                    return BadRequest();
                }

                var updateReturn = await _userRepository.Update(id, user);

                if (updateReturn != null)
                {
                    return Ok(user);
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(new { message = "Error to update user", exception = e.Message, innerExeption = e.InnerException?.Message });
            }
            
        }

       
        [HttpPost]
        public async Task<ActionResult<User>> AddUserAsync(User user)
        {
            try
            {
                var addReturn = await _userRepository.Add(user);

                if (addReturn != null)
                {
                    return CreatedAtAction("GetUser", new { id = user.Id }, user);
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(new { message = "Error to find user", exception = e.Message, innerExeption = e.InnerException?.Message });
            }
            
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUserAsync(int id)
        {
            try
            {
                var user = await _userRepository.Get(id);
                if (user == null)
                {
                    return NotFound();
                }

                var deleteReturn = _userRepository.Delete(user);

                if (deleteReturn != null)
                {
                    return CreatedAtAction("GetUser", new { id = user.Id }, user);
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(new { message = "Error to find user", exception = e.Message, innerExeption = e.InnerException?.Message });
            }
            
        }
    }
}
