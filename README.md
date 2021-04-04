# m4TR1x-Base-Solution
Base solution implementasyonu

## Özellikler

- net 5
- Autofac
- Form Factory
- Smtp Mail Service (Basit)
- Daily Message Service (Örnek Servis)
- Weather API Service (api.openweathermap.org)
- - API projesi kendi üzerinde hava durumunun güncelliğini kontrol etmektedir, grektiğinde (5dk) sunucudan güncel değerleri almaktadır.
- - Winforms üzerindeki weather api reader service API projesine bağlanıp (5dk) güncel durumu istemektedir.
- Repository Pattern
- Unit Of Work (EF Core için, şu anlık eklenmedi)
- Winforms ve diğer türleri ayırmak için her katman kendi içerisinde ayrıştırıldı
