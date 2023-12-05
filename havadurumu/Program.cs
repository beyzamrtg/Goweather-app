using System;
using System.Net.Http;
using System.Threading.Tasks;
using havadurumu.Models;
using havadurumu.Services;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        Console.Write("Lütfen hava durumu bilgisini almak istediğiniz şehri girin (istanbul, izmir veya ankara): ");
        string city = Console.ReadLine().ToLower();

        WeatherService weatherService = new WeatherService();

        try
        {
            CityWeather cityWeather = await weatherService.GetCityWeather(city);

            if (cityWeather != null)
            {
                Console.WriteLine($"Hava Durumu Bilgileri - {city}");
                Console.WriteLine($"Şu anki sıcaklık: {cityWeather.Temperature}");
                Console.WriteLine($"Rüzgar hızı: {cityWeather.Wind}");
                Console.WriteLine($"Durum: {cityWeather.Description}");
                Console.WriteLine("--------------");
                Console.WriteLine("Tahmini Hava Durumu - 3 Günlük");
                foreach (var forecast in cityWeather.Forecast)
                {
                    Console.WriteLine($"Gün {forecast.Day}: Sıcaklık: {forecast.Temperature}, Rüzgar hızı: {forecast.Wind}");
                }
                Console.WriteLine("--------------");
            }
            else
            {
                Console.WriteLine("Geçersiz şehir girişi. Lütfen istanbul, izmir veya ankara şehrinden birini girin.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Hata alındı: {e.Message}");
        }
    }
}