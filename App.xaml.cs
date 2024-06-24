namespace MauiWeather;

public partial class App : Application {
    public App(WeatherPage weatherPage) {
        InitializeComponent();

        MainPage = weatherPage;
    }
}
