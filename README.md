# Kütüphane Sistemi

- [SmartPro Teknoloji Yazılım Uzmanlığı](https://smartpro.com.tr/) kursunun bitirme projesi kapsamında **.NET 4.8.1** ile hazırlanmış bir kütüphane sistemidir.
- Tasarım [Bootstrap](https://getbootstrap.com/) yardımıyla hazırlanmışır.
- Back-End dili **C#**, veritabanı **SQL**.
- Örnek verilerden ve admin bilgisi içeren SQL sorgusu **"Örnek Veri SQL Insert Sorgusu (Migration-Update Database'den sonra)"** adıyla paylaşılmıştır. İlk önce bir veritabanı oluşturun sonra bu sorguyu çalıştırın.
- **Web.config** içerisinden **connectionStrings** kısmını kendi sisteminize göre ayarlayın.

## Ekran Görüntüleri
### Admin
![Anasayfa](https://github.com/user-attachments/assets/c81d91d2-5aca-48d4-88d6-631859623596)
![admingiris](https://github.com/user-attachments/assets/a8299312-1833-4400-9be2-9e9be0d892bc)
![adminanasayfa](https://github.com/user-attachments/assets/199dbf55-680a-4c65-a42d-5997a58a1aac)
![adminkitaplar](https://github.com/user-attachments/assets/0c0fc2e8-4f80-4408-9fec-1ae9ddb13fd5)
![adminyazarlar](https://github.com/user-attachments/assets/a764c418-cfe6-4c0a-b351-5ea43ef1c596)
![adminkitapekleduzenle](https://github.com/user-attachments/assets/74ea473d-ba8b-4ee3-bb03-95fb13ec1fc9)
### Kullanıcı
![kullanicigiris](https://github.com/user-attachments/assets/d29c1a01-e95f-4179-8444-23e6ad9c43dc)
![kullanicianasayfa](https://github.com/user-attachments/assets/3ccad544-5465-4a53-a0cc-841a19b77d58)
![kullanicikitaplar](https://github.com/user-attachments/assets/065d4b7d-d362-438d-9856-1756c799f7dd)

## Uygulama Özellikleri

- Kullanıcı için üyelik oluşturma, giriş ve çıkış yapma.
- Anasayfada kütüphanedeki kitapları listeleme. Kitap ismine göre filtreleme.

### &nbsp;&nbsp;&nbsp;&nbsp;Admin Paneli
- Stok görüntüleme.
- Yazar ve kitap ekleme, güncelleme, silme.
- Yazarlara ait kitapları listeleme.

### &nbsp;&nbsp;&nbsp;&nbsp;Kullanıcı Paneli
- Stok ve durmunu görüntüleme.
- Kitap kiralama, iade etme.
- Kiralanan kitapları listeleme.