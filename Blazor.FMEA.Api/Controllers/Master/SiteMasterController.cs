using Blazor.FMEA.Data.Master;
using Blazor.FMEA.Shared.Models.Master;
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

        [HttpGet("{Site_Number}")]
        public IActionResult GetAllSiteMasterRecordByNumber(string Site_Number)
        {
            return Ok(_siteMasterRepository.GetAll().Where(x => x.Site_Number == Site_Number).FirstOrDefault());
        }

        [HttpPut()]
        public IActionResult UpdateSiteMasterRecord(SiteMasterDO siteMasterDO)
        {
            return Ok(_siteMasterRepository.UpdateSiteMaster(siteMasterDO));
        }

        [HttpPost]
        public IActionResult CreateSiteMasterRecord(SiteMasterDO siteMasterDO)
        {
            return Ok(_siteMasterRepository.CreateSiteMaster(siteMasterDO));
        }

        [HttpDelete("{Site_Number}")]
        public IActionResult DeleteSiteMasterRecord(string Site_Number)
        {
            return Ok(_siteMasterRepository.DeleteSiteMaster(Site_Number));
        }
    }
}
