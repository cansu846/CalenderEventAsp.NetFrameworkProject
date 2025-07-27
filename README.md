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
<img width="1907" height="1079" alt="Screenshot 2025-07-27 210859" src="https://github.com/user-attachments/assets/b0338153-e4e0-4723-8dc8-53904f24ed81" />
<img width="1910" height="1079" alt="Screenshot 2025-07-27 210917" src="https://github.com/user-attachments/assets/7cdc57af-08e4-49d4-8269-00b622b3b881" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 210924" src="https://github.com/user-attachments/assets/c37ef314-2a8b-4579-95a9-3703c802cf3f" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 210931" src="https://github.com/user-attachments/assets/cb142976-2170-49c5-8e07-97ec196bc182" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 210936" src="https://github.com/user-attachments/assets/4e6fba83-4667-415b-b411-6a99c05ade37" />
<img width="1919" height="1079" alt="Screenshot 2025-07-27 211003" src="https://github.com/user-attachments/assets/56e50648-c977-4778-8450-c045a31f845f" />
<img width="1910" height="1040" alt="Screenshot 2025-07-27 205551" src="https://github.com/user-attachments/assets/186c62ed-d1d8-4499-b523-221203aa9234" />
