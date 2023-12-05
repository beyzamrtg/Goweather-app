using havadurumu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace havadurumu.Services
{
        class WeatherService
        {
            private const string BaseApiUrl = "https://goweather.herokuapp.com/weather/";

            public async Task<CityWeather> GetCityWeather(string city)
            {
                string apiUrl = $"{BaseApiUrl}{city}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string response = await client.GetStringAsync(apiUrl);
                        return JsonConvert.DeserializeObject<CityWeather>(response);
                    }
                    catch (HttpRequestException)
                    {
                        throw new Exception("Hava durumu bilgisi alınamadı.");
                    }
                }
            }
        }
    }
