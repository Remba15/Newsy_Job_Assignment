using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Newsy_Job_Assignment.Data;
using Newsy_Job_Assignment.Models;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Newsy_Job_Assignment.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController(NewsyContext context) : NewsyController(context)
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.login);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.login.Find(id));
        }

        [HttpPost]
        public IActionResult Post(Login login)
        {
            _context.login.Add(login);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, login);
        }

        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, Login login)
        {
            var loginDb = _context.login.Find(id);

            loginDb.username = login.username;
            //Should be hashed, but not needed for now
            loginDb.password = login.password;

            _context.login.Update(login);
            _context.SaveChanges();

            return Ok(new { message = "Successfully updated" });
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var loginDb = _context.login.Find(id);

            _context.login.Remove(loginDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully removed" });
        }

    }
}
