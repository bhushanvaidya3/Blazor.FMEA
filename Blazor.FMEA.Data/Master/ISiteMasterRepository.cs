using Blazor.FMEA.Shared.Models.Master;
using System.Collections.Generic;

namespace Blazor.FMEA.Data.Master
{
    public interface ISiteMasterRepository
    {
        IEnumerable<SiteMasterDO> GetAll();
        SiteMasterDO UpdateSiteMaster(SiteMasterDO smObj);

        SiteMasterDO CreateSiteMaster(SiteMasterDO smObj);
        int DeleteSiteMaster(string Site_Number);
    }
}