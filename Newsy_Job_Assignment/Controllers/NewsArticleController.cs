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
            return Ok(_context.news_article);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.news_article.Find(id));
        }

        [HttpPost]
        public IActionResult Post(News_Article article)
        {
            _context.news_article.Add(article);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, article);
        }

        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, News_Article article)
        {

            var articleDb = _context.news_article.Find(id);

            articleDb.title = article.title;
            articleDb.article_text = article.article_text;
            articleDb.author_id = article.author_id;
            articleDb.publish_date = article.publish_date;

            _context.news_article.Update(articleDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully updated." });

        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var articleDb = _context.news_article.Find(id);

            _context.news_article.Remove(articleDb);
            _context.SaveChanges();

            return Ok(new { message = "Successfully deleted." });
        }

    }
}
