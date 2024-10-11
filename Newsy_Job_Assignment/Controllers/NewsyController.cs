using Microsoft.AspNetCore.Mvc;
using Newsy_Job_Assignment.Data;

namespace Newsy_Job_Assignment.Controllers
{
    public class NewsyController : ControllerBase
    {

        protected readonly NewsyContext _context;

        public NewsyController(NewsyContext context)
        {
            _context = context;
        }

    }
}
