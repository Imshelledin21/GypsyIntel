using System;
using GypsyIntel.Calculators.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace GypsyIntel.Site.Pages
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntelController : ControllerBase
    {
        private const string Key = "693442B6-D241-480C-8E5B-EF5FC8249817";
        [HttpPost]
        public void Gather([FromBody] string data_html, [FromBody] string data_simple, [FromBody] string url, [FromBody] string prov, [FromBody] string key)
        {
            if (key != Key) throw new UnauthorizedAccessException();
            else
            {
                try
                {
                    Producer.Producer producer = new Producer.Producer();

                    IntelModel intel = new IntelModel()
                    {

                    };

                } catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}