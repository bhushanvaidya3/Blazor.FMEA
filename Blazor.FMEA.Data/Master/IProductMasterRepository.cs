using Blazor.FMEA.Shared.Models.Master;
using System.Collections.Generic;

namespace Blazor.FMEA.Data.Master
{
    public interface IProductMasterRepository
    {
        ProductMasterDO CreateProductMaster(ProductMasterDO prodObj);
        int DeleteProductMaster(string Product_Class);
        IEnumerable<ProductMasterDO> GetAll();
        ProductMasterDO UpdateProductMaster(ProductMasterDO prodObj);
    }
}