using Microsoft.AspNetCore.Mvc;

namespace GypsyIntel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntelController : ControllerBase
    {
        [HttpPost]
        public string Post([FromBody] object intel)
        {
            System.IO.File.WriteAllText($@".\Intel\intel.txt", intel.ToString());

            return "{\"success\":true}";
        }
    }
}