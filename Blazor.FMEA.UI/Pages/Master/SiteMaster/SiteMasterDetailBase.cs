using Blazor.FMEA.Shared.Models.Master;
using Blazor.FMEA.UI.Services.Master;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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

        public bool Saved { get; set; }
        #endregion

        #region Blazor Life-cycle Methods
        protected override async Task OnInitializedAsync()
        {
            if (int.Parse(Site_Number) > 0)
                SiteMasterDO = await SiteMasterDataService.GetSiteMasterRecordByNumber(Site_Number);            
        }
        #endregion

        #region Methods
        public async void HandleValidSubmit()
        {
            try
            {
                if(int.Parse(Site_Number) <= 0)
                {
                    //Add Site
                    SiteMasterDO = await SiteMasterDataService.CreateSiteMasterRecord(SiteMasterDO).ContinueWith(t => { toastService.ShowSuccess("Record created successfully!"); return t.Result; });
                }
                else
                {
                    //Update Site
                    SiteMasterDO = await SiteMasterDataService.UpdateSiteMasterRecord(SiteMasterDO).ContinueWith(t => { toastService.ShowSuccess("Record updated successfullly!"); return t.Result; });
                }
                navigationManager.NavigateTo("/siteMaster");
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
