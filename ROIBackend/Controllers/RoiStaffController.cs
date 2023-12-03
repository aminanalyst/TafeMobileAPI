using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ROIBackend.Model;

namespace ROIBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoiStaffController : ControllerBase
    {
    
        private readonly IStaffService _RoiStaffService;

        public RoiStaffController(IStaffService StaffService)
        {
            _RoiStaffService = StaffService;
        }

        [HttpGet]
        public IEnumerable<RoiStaffModel> GetAll()
        {
            return _RoiStaffService.GetAll();
        }

        [HttpPost]
        public IActionResult Add([FromBody] RoiStaffModel data)
        {
            _RoiStaffService.Add(data);
            return Ok();
        }
    }
}
