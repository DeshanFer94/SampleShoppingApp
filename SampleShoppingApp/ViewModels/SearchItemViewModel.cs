using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SampleShoppingApp.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShoppingApp.ViewModels
{
    public partial class SearchItemViewModel:ObservableObject
    {
        IShoppingService _shoppingService;

        [ObservableProperty]
        private int _code;

        [ObservableProperty]
        private string _image;

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private double _price;

        [ObservableProperty]
        private string _description;


        [RelayCommand]
        public async void GetItemInfo()
        {
          //  Debug.WriteLine(Code);

         var item= await _shoppingService.GetItemInfoFromRestService(Code);
            Image = item.Image;
            Name = item.Name;
            Price = item.Price;
            Description = item.Description;
           
        }

        public SearchItemViewModel(IShoppingService shoppingService )
        {
            _shoppingService = shoppingService;
        }
    }
}
