using Microsoft.AspNetCore.Mvc;
using Newsy_Job_Assignment.Data;
using Newsy_Job_Assignment.Models;

namespace Newsy_Job_Assignment.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class NewsUserController(NewsyContext context) : NewsyController(context)
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.news_user);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.news_user.Find(id));
        }

        [HttpPost]
        public IActionResult Post(News_User user)
        {
            _context.news_user.Add(user);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, user);
        }

        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, News_User user)
        {

            var userDb = _context.news_user.Find(id);

            //Manual for database test, later mapper
            userDb.name = user.name;
            userDb.surname = user.surname;
            userDb.email = user.email;
            userDb.author = user.author;
            userDb.registration_date = user.registration_date;

            _context.news_user.Update(userDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully updated." });

        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var userDb = _context.news_user.Find(id);

            _context.news_user.Remove(userDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully deleted." });
        }

    }
}
