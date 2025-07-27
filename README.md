# 🗓 ASP.NET MVC Event Calendar Projesi

Bu proje, kullanıcıların takvim üzerine etkinlik ekleyebildiği, sürükle-bırak yöntemiyle etkinlikleri yerleştirdiği ve kategori seçerek renkli etkinlikler oluşturabildiği dinamik bir takvim uygulamasıdır.

## 🎯 Temel Özellikler

### 👥 Kullanıcı (Default) Tarafı

- ✅ **Etkinlik Oluşturma:** Kullanıcı, metin kutusu ile etkinlik adını yazar ve bir kategori seçerek takvime ekler.
- 🎨 **Kategori Seçimi:** Etkinlik oluştururken kategori (veya renk) seçilebilir. Her kategori belirli bir renk ile ilişkilidir.
- 🖱 **Sürükle-Bırak:** Etkinlikler takvim üzerine sürüklenerek bırakılır.
- ⏱ **Süre Tanımlama:** Takvime bırakılan etkinlik başlangıç-bitiş tarihine göre belirlenir. (Örneğin: tüm gün veya 1 saat)
- 🔁 **Veritabanı Kaydı:** AJAX kullanılarak etkinlik bilgileri `Event` tablosuna kaydedilir.
- ♻️ **Sayfa Yenilendiğinde Otomatik Yükleme:** Tüm kayıtlı etkinlikler sayfa açıldığında otomatik olarak takvime yüklenir.

---

### 🛠 Admin Paneli

#### 📁 Kategori İşlemleri (`CategoryController`)
- Kategori listeleme
- Kategori ekleme, güncelleme, silme
- Kategori rengi seçimi (Bootstrap renk sınıflarıyla)

#### 📅 Etkinlik İşlemleri (`EventController`)
- Etkinlik listeleme
- Etkinlik düzenleme (başlık, tarih, kategori vs.)
- Etkinlik silme

---

## 🧩 Kullanılan Teknolojiler

- ASP.NET MVC 4.7
- Entity Framework
- jQuery & AJAX
- FullCalendar.js
- Bootstrap 4/5
- MSSQL Server

---

## 📦 Veritabanı Tabloları

### `Events`

| Kolon Adı        | Tipi        | Açıklama                  |
|------------------|-------------|---------------------------|
| Id               | int (PK)    | Etkinlik ID               |
| Title            | string      | Etkinlik başlığı          |
| Start            | DateTime    | Başlangıç tarihi          |
| End              | DateTime?   | Bitiş tarihi (nullable)   |
| AllDay           | bool        | Tüm gün mü?               |
| BackgroundColor  | string      | Arka plan rengi           |
| BorderColor      | string      | Kenarlık rengi            |
| CategoryId       | int (FK)    | Kategori ile ilişki       |

### `Categories`

| Kolon Adı      | Tipi      | Açıklama                  |
|----------------|-----------|---------------------------|
| Id             | int (PK)  | Kategori ID               |
| CategoryName   | string    | Kategori adı              |
| Color          | string    | Bootstrap renk sınıfı     |

---

## ✨ Geliştirilebilir Özellikler

- Kullanıcı bazlı etkinlik filtreleme
- Etkinlik detay penceresi (modal)
- Haftalık/günlük görünümde detaylı işlem butonları
- Yetkilendirme ve kullanıcı yönetimi (Admin/User ayrımı)

---

## 📌 Ekran Görüntüsü

<img width="1919" height="1079" alt="Screenshot 2025-07-27 201636" src="https://github.com/user-attachments/assets/7743b336-9212-4c5e-bf4d-ab6d401a420c" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 201701" src="https://github.com/user-attachments/assets/43fef579-5369-42fc-9df4-f158271111bc" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 201710" src="https://github.com/user-attachments/assets/38fc777c-14a9-461e-b715-36d67a814cc3" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 201718" src="https://github.com/user-attachments/assets/730cf80a-16ec-431f-a074-059cfaa8bfee" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 201727" src="https://github.com/user-attachments/assets/6222d004-3532-4ca3-bd24-ac0fa9195410" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 201742" src="https://github.com/user-attachments/assets/2de08871-4d47-4a20-9633-57f731df3b9b" />


