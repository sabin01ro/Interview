using Common.Common;
using Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Interview.Controllers
{
    [ApiController]
    [Route("api/Upload")]
    public class UploadController : Controller
    {

        IPutCsvDataToDabase _putCsvDataToDabase = new PutCsvDataToDabase();
        [HttpPost]
        [Route("[action]")]
        public Task<HttpResponseMessage> Upload([FromForm] IFormFile body)
        {
            try
            {
                using (var reader = new StreamReader(body.OpenReadStream()))
                {
                    _putCsvDataToDabase.PutCsvDataToDatabase(reader);
                }
                var response = new HttpResponseMessage(HttpStatusCode.OK);

                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent(ex.Message);
                return Task.FromResult(response);
            }
        }
    }
}
