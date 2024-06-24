using MauiWeather.Constants;
using MauiWeather.Interfaes;
using MauiWeather.Model;

namespace MauiWeather.Service {
    public class WeatherService(HttpClient client) : IWeather {

        public async Task<Root> GetWeatherDataByCoords(double lat, double lon) {

            var responseMessage = await client.GetAsync(
                $"{Constant.WEATHER_URL_BASE}/forecast?lat={lat}&lon={lon}&appid={Constant.WEATHER_APIkEY}");

            if (responseMessage.IsSuccessStatusCode) {

                var res = await responseMessage.Content.ReadAsStringAsync();

                JsonSerializer.Deserialize<Root>(res);
            }

            return new Root();
        }

        public async Task<Root> GetWeatherDataByCity(string city) {

            var responseMessage = await client.GetAsync(
                $"{Constant.WEATHER_URL_BASE}/forecast?q={city}&appid={Constant.WEATHER_APIkEY}");

            if (responseMessage.IsSuccessStatusCode) {

                var res = await responseMessage.Content.ReadAsStringAsync();

                JsonSerializer.Deserialize<Root>(res);
            }

            return new Root();
        }
    }
}
