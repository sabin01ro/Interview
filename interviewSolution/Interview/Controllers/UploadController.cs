using Common.Common;
using Common.Interfaces;
using Microsoft.AspNetCore.Cors;
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

        [EnableCors("AllowOrigin")]
        [HttpPost]
        [Route("[action]")]
        public IActionResult Upload([FromForm] IFormFile body)
        {          
            try
            {
                using (var reader = new StreamReader(body.OpenReadStream()))
                {
                    _putCsvDataToDabase.PutCsvDataToDatabase(reader);
                }
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent("File uploaded succesfuly");

                return Json(new
                {
                    response = response,
                    data = response.Content,
                    messege = "File uploaded succesfuly"
                });
            }
            catch (Exception ex)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent(ex.Message);
                return Json(new
                {
                    response = response,
                    data = response.Content,
                    messege = ex.Message
                });
            }
        }
    }
}
