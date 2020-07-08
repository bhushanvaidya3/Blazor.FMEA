using Blazor.FMEA.Shared.Models.Master;
using Blazor.FMEA.UI.Services.Master;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Pages.Master
{
    public class SiteMasterBase: ComponentBase
    {
        [Inject]
        public ISiteMasterDataService siteMasterDataService { get; set; }
        public List<SiteMasterDO> siteMasterDOs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            siteMasterDOs = (await siteMasterDataService.GetSiteMasterDOs()).ToList();
        }
    }
}
