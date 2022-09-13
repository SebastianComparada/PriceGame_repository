using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpGet]
        public Response GetPrices(string name)
        {
            return PriceService.GetPrices();
        }

        [HttpPost]
        public Response GetPrices(string name)
        {
            return PriceService.GetPrices();
        }
    }
}
