using System;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task Post([FromBody] string data_html, [FromBody] string data_simple, [FromBody] string url, [FromBody] string prov, [FromBody] string key)
        {
            if (key != Key) throw new UnauthorizedAccessException();
            else
            {
                try
                {
                    string page = GetIntelPageName(url);
                    Producer.Producer producer = new Producer.Producer();

                    await LogActivity(url, prov, producer, page);
                    await LogPageIntel(data_html, data_simple, url, prov, producer, page);

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private static async Task LogPageIntel(string data_html, string data_simple, string url, string prov, Producer.Producer producer, string page)
        {
            IntelModel pageIntel = new IntelModel()
            {
                Id = $@"Utopia.PageIntel.{page}.{prov}",
                HtmlData = data_html,
                SimpleData = data_simple,
                Province = prov,
                Url = url,
                Topic = $@"Utopia.PageIntel.{page}",
                IntelTimestamp = DateTime.UtcNow
            };
            await producer.Produce(pageIntel);
        }

        private static string GetIntelPageName(string url)
        {
            var urlParts = url.Split('/');
            var page = urlParts.ToList().Last();
            return page;
        }

        private static async Task LogActivity(string url, string prov, Producer.Producer producer, string page)
        {
            IntelModel activity = new IntelModel()
            {
                Id = "Utopia.ProvinceActivityMonitor." + prov,
                HtmlData = url,
                Province = prov,
                Topic = $@"Utopia.ProvinceActivityMonitor.{page}",
                Url = url,
                IntelTimestamp = DateTime.UtcNow
            };
            await producer.Produce(activity);
        }
    }
}