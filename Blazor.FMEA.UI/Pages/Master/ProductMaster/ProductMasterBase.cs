using Blazor.FMEA.Shared.Models.Master;
using Blazor.FMEA.UI.Services.Master;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Pages.Master.ProductMaster
{
    public class ProductMasterBase: ComponentBase
    {
        [Inject]
        private IProductMasterDataService _productMasterDataService { get; set; }

        [Inject]
        IToastService toastService { get; set; }

        public List<ProductMasterDO> productMasterDOs { get; set; }
        protected bool showModal = false;

        protected override async Task OnInitializedAsync()
        {
            productMasterDOs = (await _productMasterDataService.GetProductMasterDOs()).ToList();
        }

        protected void HandleDelete()
        {

        }
    }
}
