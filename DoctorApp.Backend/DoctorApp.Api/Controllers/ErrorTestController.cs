using DoctorApp.Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorApp.Api.Controllers
{
    public class ErrorTestController:BaseApiController
    {
        private readonly DoctorContext _context;
        public ErrorTestController(DoctorContext context)
        {
            _context = context;
            
        }


        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetNotAuthorize()
        {
            return "No Autorizado";
        }
    }
}
