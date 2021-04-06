# m4TR1x-Base-Solution
Base solution implementasyonu

## Özellikler

- net 5
- Dependency Injection (Autofac)
- Form Factory
- Smtp Mail Service (Basit)
- Daily Message Service (Örnek Servis)
- Weather API Service (api.openweathermap.org) *(m4TR1x.API.Business)*
- - API projesi kendi üzerinde hava durumunun güncelliğini kontrol etmektedir, grektiğinde (5dk) sunucudan güncel değerleri almaktadır.
- Weather Api Reader Service *(m4TR1x.Business)*
- - Servis API projesine bağlanıp (5dk) güncel durumu istemektedir ve event dinleyicilerine göndermektedir.
- Repository Pattern
- Unit Of Work (EF Core için, şu anlık eklenmedi)
- Winforms ve diğer türleri ayırmak için her katman kendi içerisinde ayrıştırıldı
