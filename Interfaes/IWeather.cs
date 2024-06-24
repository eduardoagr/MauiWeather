using MauiWeather.Model;

namespace MauiWeather.Interfaes {
    public interface IWeather {
        Task<Root> GetWeatherDataByCoords(double lat, double lon);

        Task<Root> GetWeatherDataByCity(string city);
    }
}
