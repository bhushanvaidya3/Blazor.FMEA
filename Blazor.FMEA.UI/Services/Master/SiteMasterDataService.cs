using Blazor.FMEA.Shared.Models.Master;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Services.Master
{
    public class SiteMasterDataService : ISiteMasterDataService
    {
        private readonly HttpClient _httpClient;

        public SiteMasterDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<SiteMasterDO>> GetSiteMasterDOs()
        {
            //return await JsonSerializer.DeserializeAsync<IEnumerable<SiteMasterDO>>
            //    (await _httpClient.GetStreamAsync($"/api/sitemaster"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return await _httpClient.GetJsonAsync<SiteMasterDO[]>($"/api/sitemaster");
        }
    }
}
