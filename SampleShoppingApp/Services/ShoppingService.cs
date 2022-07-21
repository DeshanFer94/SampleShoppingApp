using SampleShoppingApp.Models;
using SampleShoppingApp.RestServices;
using SampleShoppingApp.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShoppingApp.Services
{
    public class ShoppingService : IShoppingService
    {
        IShoppingAPIService _shoppingAPIService;
        public async Task<ShoppingItemModel> GetItemInfoFromRestService(int code)
        {
            return await _shoppingAPIService.GetItemInfo(code);

        }

        public ShoppingService(IShoppingAPIService shoppingAPIService)
        {
            _shoppingAPIService = shoppingAPIService;
        }
    }
}
