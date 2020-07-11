using Blazor.FMEA.Shared.Models.Master;
using Blazor.FMEA.UI.Services.Master;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Pages.Master.SiteMaster
{
    public class SiteMasterDetailBase: ComponentBase
    {
        [Inject]
        NavigationManager navigationManager { get; set; }

        [Inject]
        public ISiteMasterDataService SiteMasterDataService { get; set; }

        [Parameter]
        public string Site_Number { get; set; }

        public SiteMasterDO SiteMasterDO { get; set; } = new SiteMasterDO();

        protected override async Task OnInitializedAsync()
        {
            SiteMasterDO = await SiteMasterDataService.GetSiteMasterRecordByNumber(Site_Number);
        }

        public async void HandleValidSubmit()
        {
            try
            {
                SiteMasterDO = await SiteMasterDataService.UpdateSiteMasterRecord(SiteMasterDO);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public void HandleNavigateToListPage()
        {
            navigationManager.NavigateTo("/siteMaster");
        }
    }
}
