using Blazor.FMEA.Shared.Models.Master;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Services.Master
{
    public interface IProductMasterDataService
    {
        Task<ProductMasterDO> CreateProductMasterRecord(ProductMasterDO ProductMasterDO);
        Task<HttpResponseMessage> DeleteProductMaster(string Product_Class);
        Task<IEnumerable<ProductMasterDO>> GetProductMasterDOs();
        Task<ProductMasterDO> GetProductMasterRecordByNumber(string Product_Class);
        Task<ProductMasterDO> UpdateProductMasterRecord(ProductMasterDO ProductMasterDO);
    }
}