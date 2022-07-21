using RestEase;
using SampleShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShoppingApp.RestServices
{
    [Header("User-Agent", "RestEase")]
    public interface IShoppingAPIService
    {
        [Get("/ShoppingCart/GetItem/{code}")]
        Task<ShoppingItemModel> GetItemInfo([Path]int code);
    }
}
