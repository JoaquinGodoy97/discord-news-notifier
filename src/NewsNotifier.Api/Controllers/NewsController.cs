using Microsoft.AspNetCore.Mvc;
using NewsServiceApp.Services;

namespace NewsServiceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetNews()
        {
            var news = await _newsService.GetNewsAsync();
            return Ok(news);
        }
    }
}
