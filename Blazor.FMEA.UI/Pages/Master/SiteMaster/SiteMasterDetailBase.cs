using Blazor.FMEA.Shared.Models.Master;
using Blazor.FMEA.UI.Services.Master;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Pages.Master.SiteMaster
{
    public class SiteMasterDetailBase: ComponentBase
    {
        #region Services
        [Inject]
        NavigationManager navigationManager { get; set; }

        [Inject]
        public ISiteMasterDataService SiteMasterDataService { get; set; }

        [Inject]
        IToastService toastService { get; set; }
        #endregion

        #region Parameters
        [Parameter]
        public string Site_Number { get; set; }
        #endregion

        #region Variables
        public SiteMasterDO SiteMasterDO { get; set; } = new SiteMasterDO();

        #endregion

        #region Blazor Life-cycle Methods
        protected override async Task OnInitializedAsync()
        {
            SiteMasterDO = await SiteMasterDataService.GetSiteMasterRecordByNumber(Site_Number);
        }
        #endregion

        #region Methods
        public async void HandleValidSubmit()
        {
            try
            {
                SiteMasterDO = await SiteMasterDataService.UpdateSiteMasterRecord(SiteMasterDO).ContinueWith(t => { toastService.ShowSuccess("Record updated successfullly!"); return t.Result; });
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
        #endregion

    }
}
