using FlyTickets.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FlyTickets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : ControllerBase
    {

        [HttpGet(Name = "GetValues")]
        public ActionResult Get()
        {
            using (var db = new testContext())
            {
                var Parameter = new SqlParameter("@parameter", 4);
                //var lst = db.FlightsInfos
                //        .SqlQuery<dynamic>($"EXECUTE dbo.GetMostPopularBlogsForUser {Parameter}")
                //.ToList();
                var lst = "";
                return Ok(lst);
            }

        }

    }
}




