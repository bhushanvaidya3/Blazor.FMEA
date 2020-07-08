using Blazor.FMEA.Shared.Models.Master;
using System.Collections.Generic;

namespace Blazor.FMEA.Data.Master
{
    public interface ISiteMasterRepository
    {
        IEnumerable<SiteMasterDO> GetAll();
    }
}