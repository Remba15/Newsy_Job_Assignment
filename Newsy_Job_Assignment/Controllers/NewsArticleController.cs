using Microsoft.AspNetCore.Mvc;
using Newsy_Job_Assignment.Data;
using Newsy_Job_Assignment.Models;

namespace Newsy_Job_Assignment.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class NewsArticleController(NewsyContext context) : NewsyController(context)
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.newsarticle);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.newsarticle.Find(id));
        }

        [HttpPost]
        public IActionResult Post(NewsArticle article)
        {
            _context.newsarticle.Add(article);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, article);
        }

        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, NewsArticle article)
        {

            var articleDb = _context.newsarticle.Find(id);

            articleDb.title = article.title;
            articleDb.articletext = article.articletext;
            articleDb.authorid = article.authorid;
            articleDb.publishdate = article.publishdate;

            _context.newsarticle.Update(articleDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully updated." });

        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var articleDb = _context.newsarticle.Find(id);

            _context.newsarticle.Remove(articleDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully deleted." });
        }

    }
}
