using Blazor.FMEA.Shared.Models.Master;
using Blazor.FMEA.UI.Services.Master;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.UI.Pages.Master.ProductMaster
{
    public class ProductMasterDetailBase : ComponentBase
    {
        [Inject]
        private IProductMasterDataService productMasterDataService { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IToastService toastService { get; set; }

        [Parameter]
        public string Product_Class { get; set; }

        public ProductMasterDO ProductMasterDO { get; set; } = new ProductMasterDO();

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Product_Class) && Product_Class != "0")
            {
                ProductMasterDO = await productMasterDataService.GetProductMasterRecordByNumber(Product_Class);
            }
        }

        protected async void HandleValidSubmit()
        {
            try
            {
                if (string.IsNullOrEmpty(Product_Class) || Product_Class == "0")
                {
                    //Add Site
                    ProductMasterDO = await productMasterDataService.CreateProductMasterRecord(ProductMasterDO).ContinueWith(t => { toastService.ShowSuccess("Record created successfully!"); return t.Result; });
                }
                else
                {
                    //Update Site
                    ProductMasterDO = await productMasterDataService.UpdateProductMasterRecord(ProductMasterDO).ContinueWith(t => { toastService.ShowSuccess("Record updated successfullly!"); return t.Result; });
                }
                navigationManager.NavigateTo("/ProductMaster");
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        protected void HandleNavigationToListPage()
        {
            navigationManager.NavigateTo("/productMaster");
        }
    }
}
