using Blazor.FMEA.Shared.Models.Master;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Services.Master
{
    public class ProductMasterDataService : IProductMasterDataService
    {
        private readonly HttpClient _httpClient;

        public ProductMasterDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductMasterDO>> GetProductMasterDOs()
        {
            return await _httpClient.GetJsonAsync<ProductMasterDO[]>($"api/productMaster");
        }

        public async Task<HttpResponseMessage> DeleteProductMaster(string Product_Class)
        {
            return await _httpClient.DeleteAsync($"api/ProductMaster/{Product_Class}");
        }

        public async Task<ProductMasterDO> GetProductMasterRecordByNumber(string Product_Class)
        {
            return (await _httpClient.GetJsonAsync<ProductMasterDO>($"/api/ProductMaster/{Product_Class}"));
        }

        public async Task<ProductMasterDO> UpdateProductMasterRecord(ProductMasterDO ProductMasterDO)
        {
            return await _httpClient.PutJsonAsync<ProductMasterDO>($"/api/ProductMaster/", ProductMasterDO);
        }

        public async Task<ProductMasterDO> CreateProductMasterRecord(ProductMasterDO ProductMasterDO)
        {
            return await _httpClient.PostJsonAsync<ProductMasterDO>($"/api/ProductMaster", ProductMasterDO);
        }
    }
}
