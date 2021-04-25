# ReCapProject
Araba Kiralama Sistemi

Oluşturulanlar:

-ReCapProject 

-Entities, DataAccess, Business ve Console katmanları

-Bir araba nesnesi "Car" 

-Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanları

-InMemory formatta GetById, GetAll, Add... oprasyonları

.............................................................................................

Car nesnesine ek olarak;

-Brand ve Color nesneleri  :      Brand-->Id,Name       Color-->Id,Name

-Sql Server tarafında yeni bir veritabanı kuruldu. Cars,Brands,Colors tabloları 

-Sisteme Generic IEntityRepository altyapısı 

-Car, Brand ve Color nesneleri için Entity Framework altyapısı

-GetCarsByBrandId , GetCarsByColorId servisleri

- Sisteme yeni araba eklendiğinde aşağıdaki kurallar çalışsın

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır.

..............................................................................................

-Core Katmanı

-IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyaları

-Car, Brand, Color sınıfları için tüm CRUD operasyonları hazır hale getirildi

-Console'da Tüm CRUD operasyonları Car, Brand, Model nesneleri için test edildi. GetAll, GetById...

-Arabalar listelendi. BrandName, ColorName olarak.

...............................................................................................
