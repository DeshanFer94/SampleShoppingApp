using SampleShoppingApp.Services.Abstractions;
using SampleShoppingApp.ViewModels;
using SampleShoppingApp.Views;
using RestEase.HttpClientFactory;
using SampleShoppingApp.RestServices;

namespace SampleShoppingApp;


public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UsePrismApp<App>(prism =>
			{
				prism.RegisterTypes(container =>
				{
					container.Register<IShoppingService, Services.ShoppingService>();
					//container.RegisterForNavigation(typeof(SearchItemView), typeof(SearchItemViewModel));
					container.RegisterForNavigation<SearchItemView, SearchItemViewModel>("SearchItemViewPage");
				})
				.ConfigureServices(services =>
				{
					services.AddRestEaseClient<IShoppingAPIService>("http://sampleshopping.azurewebsites.net");
				})
				.OnAppStart(navigationService => navigationService.CreateBuilder().AddNavigationPage().AddSegment<SearchItemViewModel>().Navigate());
				
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
