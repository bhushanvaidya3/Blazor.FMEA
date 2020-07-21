using Blazor.FMEA.Data.Master;
using Blazor.FMEA.Shared.Models.Master;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Blazor.FMEA.Api.Controllers.Master
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductMasterController: ControllerBase
    {
        private readonly IProductMasterRepository _productMasterRepository;

        public ProductMasterController(IProductMasterRepository productMasterRepository)
        {
            _productMasterRepository = productMasterRepository;
        }

        [HttpGet]
        public IActionResult GetAllProductRecords()
        {
            return Ok(_productMasterRepository.GetAll().ToArray());
        }

        [HttpGet("{Product_Class}")]
        public IActionResult GetAllProductMasterRecordByNumber(string Product_Class)
        {
            return Ok(_productMasterRepository.GetAll().Where(x => x.Product_Class == Product_Class).FirstOrDefault());
        }

        [HttpPut()]
        public IActionResult UpdateProductMasterRecord(ProductMasterDO ProductMasterDO)
        {
            return Ok(_productMasterRepository.UpdateProductMaster(ProductMasterDO));
        }

        [HttpPost]
        public IActionResult CreateProductMasterRecord(ProductMasterDO ProductMasterDO)
        {
            return Ok(_productMasterRepository.CreateProductMaster(ProductMasterDO));
        }

        [HttpDelete("{Product_Class}")]
        public IActionResult DeleteProductMasterRecord(string Product_Class)
        {
            return Ok(_productMasterRepository.DeleteProductMaster(Product_Class));
        }

    }
}
