using MauiWeather.Service;

namespace MauiWeather;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<HttpClient>();

        builder.Services.AddSingleton<WeatherService>();

        builder.Services.AddSingleton<WeatherPageViewModel>();

		builder.Services.AddSingleton<WeatherPage>();

		return builder.Build();
	}
}
