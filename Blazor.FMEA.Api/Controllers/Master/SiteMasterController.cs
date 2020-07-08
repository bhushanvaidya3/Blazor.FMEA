using Blazor.FMEA.Data.Master;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Blazor.FMEA.Api.Controllers.Master
{
    [ApiController]
    [Route("api/[controller]")]
    public class SiteMasterController : ControllerBase
    {
        private readonly ISiteMasterRepository _siteMasterRepository;

        public SiteMasterController(ISiteMasterRepository siteMasterRepository)
        {
            _siteMasterRepository = siteMasterRepository;
        }

        [HttpGet]
        public IActionResult GetAllSiteMasterRecords()
        {
            return Ok(_siteMasterRepository.GetAll().ToArray());
        }
    }
}
