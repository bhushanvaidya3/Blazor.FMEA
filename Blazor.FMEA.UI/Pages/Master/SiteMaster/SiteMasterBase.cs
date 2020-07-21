using Blazor.FMEA.Shared.Models.Master;
using Blazor.FMEA.UI.Services.Master;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Pages.Master
{
    public class SiteMasterBase : ComponentBase
    {
        [Inject]
        public ISiteMasterDataService siteMasterDataService { get; set; }

        [Inject]
        IToastService toastService { get; set; }

        //[Inject]
        //private IJSRuntime JSRuntime { get; set; }
        public List<SiteMasterDO> siteMasterDOs { get; set; }
        protected bool showModal = false;

        protected override async Task OnInitializedAsync()
        {
            siteMasterDOs = (await siteMasterDataService.GetSiteMasterDOs()).ToList();
        }

        public async Task HandleDelete(string Site_Number)
        {
            var res = (await siteMasterDataService.DeleteSiteMaster(Site_Number) //Delete the site master record
                .ContinueWith(t => { toastService.ShowSuccess("Record deleted successfully!"); return t.Result; })); //Show toast message                
            showModal = false; //Hide the modal            
            siteMasterDOs = (await siteMasterDataService.GetSiteMasterDOs()).ToList(); //Refresh Site List
        }
    }
}
