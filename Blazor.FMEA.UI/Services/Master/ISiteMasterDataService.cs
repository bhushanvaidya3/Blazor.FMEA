using Blazor.FMEA.Shared.Models.Master;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Services.Master
{
    public interface ISiteMasterDataService
    {
        Task<IEnumerable<SiteMasterDO>> GetSiteMasterDOs();
    }
}