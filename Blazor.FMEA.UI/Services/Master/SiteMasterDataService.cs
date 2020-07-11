using Blazor.FMEA.Shared.Models.Master;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
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

            return await _httpClient.GetJsonAsync<SiteMasterDO[]>($"/api/sitemaster/");
        }

        public async Task<SiteMasterDO> GetSiteMasterRecordByNumber(string Site_Number)
        {
            return (await _httpClient.GetJsonAsync<SiteMasterDO>($"/api/sitemaster/{Site_Number}"));
        }

        public async Task<SiteMasterDO> UpdateSiteMasterRecord(SiteMasterDO siteMasterDO)
        {
            return await _httpClient.PutJsonAsync<SiteMasterDO>($"/api/sitemaster/", siteMasterDO);
        }
    }
}
