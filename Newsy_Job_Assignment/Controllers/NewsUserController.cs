using Microsoft.AspNetCore.Mvc;
using Newsy_Job_Assignment.Data;
using Newsy_Job_Assignment.Models;

namespace Newsy_Job_Assignment.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class NewsUserController : ControllerBase
    {

        private readonly NewsyContext _context;

        public NewsUserController(NewsyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.newsuser);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.newsuser.Find(id));
        }

        [HttpPost]
        public IActionResult Post(NewsUser user)
        {
            _context.newsuser.Add(user);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, user);
        }

        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, NewsUser user)
        {

            var userDb = _context.newsuser.Find(id);

            //Manual for database test, later mapper
            userDb.name = user.name;
            userDb.surname = user.surname;
            userDb.email = user.email;
            userDb.author = user.author;
            userDb.registrationdate = user.registrationdate;

            _context.newsuser.Update(userDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully updated." });

        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var userDb = _context.newsuser.Find(id);

            _context.newsuser.Remove(userDb);
            _context.SaveChanges();

            return Ok(new { message = "SUccessfully deleted." });
        }

    }
}
