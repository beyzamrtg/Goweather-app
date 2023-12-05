Hava Durumu Bilgi Uygulaması
Bu uygulama, kullanıcıdan bir şehir adı alan ve o şehre ait güncel hava durumu bilgilerini ve 3 günlük tahminleri gösteren bir konsol uygulamasıdır. Aşağıda, uygulamanın nasıl kullanılacağı ve kodunun nasıl çalıştığına dair açıklamalar bulunmaktadır.bu uygulama virsual studio da yazılmıştır.

Kullanım
Kullanıcıdan bir şehir adı istenir. Kabul edilen şehir adları: İstanbul, İzmir veya Ankara.

Girilen şehir adına ait hava durumu bilgileri, goweather.herokuapp.com adresinden alınarak görüntülenir.

Eğer geçerli bir şehir adı girilmişse, şu bilgileri içerir:

Şu anki sıcaklık
Rüzgar hızı
Hava durumu açıklaması
3 günlük tahmini hava durumu bilgileri
Eğer geçerli bir şehir adı girilmemişse veya hava durumu bilgileri alınamazsa, bir hata mesajı görüntülenir.

Kod Yapısı
CityWeather Sınıfı
Temperature: Şu anki sıcaklık bilgisini tutar.
Wind: Rüzgar hızı bilgisini tutar.
Description: Hava durumu açıklamasını tutar.
Forecast: 3 günlük tahmini hava durumu bilgilerini tutan dizi.
Forecast Sınıfı
Day: Gün adını tutar.
Temperature: Günlük sıcaklık bilgisini tutar.
Wind: Günlük rüzgar hızı bilgisini tutar.
WeatherService Sınıfı
BaseApiUrl: Hava durumu API'sinin temel URL'sini tanımlar.
GetCityWeather(string city): Verilen şehir adına ait hava durumu bilgilerini API üzerinden alır ve CityWeather sınıfı olarak döndürür.
Program Sınıfı
Kullanıcıdan bir şehir adı alır.
WeatherService sınıfını kullanarak hava durumu bilgilerini alır.
Alınan bilgileri ekrana yazdırır.
Hata durumlarında uygun hata mesajını ekrana yazdırır.
Bağımlılıklar
Newtonsoft.Json: JSON serileştirme/deserileştirme işlemleri için kullanılır.
System.Net.Http: HTTP istekleri göndermek için kullanılır.
Hata Durumları
Şehir adı geçerli değilse veya hava durumu bilgileri alınamazsa, kullanıcıya bir hata mesajı gösterilir.
