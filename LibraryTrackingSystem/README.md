# 📚 Library Tracking System

<div align="center">

![Windows Forms](Images/WF.png)
![SQL Server](Images/DB.png)

**Modern ve kullanıcı dostu bir kütüphane yönetim sistemi**

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=for-the-badge&logo=windows)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927?style=for-the-badge&logo=microsoft-sql-server)](https://www.microsoft.com/sql-server)
[![C#](https://img.shields.io/badge/C%23-8.0-239120?style=for-the-badge&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

</div>

---

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Gereksinimler](#-gereksinimler)
- [Kurulum](#-kurulum)
- [Veritabanı Yapısı](#-veritabanı-yapısı)
- [Kullanım Kılavuzu](#-kullanım-kılavuzu)
- [Proje Yapısı](#-proje-yapısı)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [Geliştirme Notları](#-geliştirme-notları)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)

---

## 🎯 Proje Hakkında

**Library Tracking System**, Windows Forms teknolojisi kullanılarak geliştirilmiş profesyonel bir kütüphane yönetim sistemidir. Bu uygulama, kitapların kayıt altına alınması, güncellenmesi, silinmesi ve aranması gibi temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirmenize olanak sağlar.

Uygulama, SQL Server veritabanı ile entegre çalışarak kitapların tüm bilgilerini güvenli bir şekilde saklar ve yönetir. Modern ve kullanıcı dostu arayüzü sayesinde kolayca kullanılabilir.

### 🎨 Öne Çıkan Özellikler

- ✨ **Modern Arayüz**: Renkli butonlar ve düzenli form yapısı
- 🔍 **Anlık Arama**: Yazdıkça arama yapma özelliği
- 📊 **DataGridView Entegrasyonu**: Tüm kitapları tablo formatında görüntüleme
- 🔒 **Güvenli Veri Yönetimi**: SQL Server ile güvenli veri saklama
- ⚡ **Hızlı ve Etkili**: Optimize edilmiş veritabanı sorguları

---

## ✨ Özellikler

### 📖 Kitap Yönetimi

#### ✅ Kitap Ekleme
- Yeni kitapları veritabanına ekleme
- Tüm kitap bilgilerini (başlık, yazar, tür, dil, yayınevi, sayfa sayısı, yayın yılı) kaydetme
- Otomatik ID oluşturma
- Başarı mesajı gösterimi

#### ✅ Kitap Güncelleme
- Mevcut kitap bilgilerini düzenleme
- DataGridView'den seçilen kitabın bilgilerini form alanlarına yükleme
- Güncellenmiş bilgileri veritabanına kaydetme

#### ✅ Kitap Silme
- Kitapları veritabanından silme
- ID kontrolü ile güvenli silme işlemi
- Silme onay mesajı

#### ✅ Kitap Listeleme
- Tüm kitapları DataGridView'de görüntüleme
- Otomatik sütun genişletme
- Salt okunur mod (yanlışlıkla düzenlemeyi önler)

#### ✅ Detay Görüntüleme
- Tablodan seçilen kitabın detaylarını form alanlarına yükleme
- Tek tıkla kitap bilgilerine erişim

### 🔍 Arama Özellikleri

- ✅ **Anlık Arama**: Yazdıkça arama yapma
- ✅ **Çoklu Alan Arama**: 
  - ID
  - Başlık (Title)
  - Yazar (Author)
  - Tür (Genre)
- ✅ **Filtreleme**: Arama sonuçlarını anlık olarak filtreleme
- ✅ **Güvenli Arama**: SQL injection koruması

### 📊 Veri Alanları

Her kitap için aşağıdaki bilgiler saklanır:

| Alan | Açıklama | Tip |
|------|----------|-----|
| **ID** | Otomatik oluşturulan benzersiz kimlik | INT (Identity) |
| **Title** | Kitap başlığı | NVARCHAR(200) |
| **Author** | Yazar adı | NVARCHAR(100) |
| **Genre** | Kitap türü/kategorisi | NVARCHAR(50) |
| **Language** | Kitap dili | NVARCHAR(50) |
| **Publisher** | Yayınevi | NVARCHAR(100) |
| **PageCount** | Sayfa sayısı | INT |
| **PublicationYear** | Yayın yılı | INT |

---

## 🛠️ Teknolojiler

### Kullanılan Teknolojiler

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat-square&logo=dotnet)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=flat-square&logo=windows)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927?style=flat-square&logo=microsoft-sql-server)
![C#](https://img.shields.io/badge/C%23-8.0-239120?style=flat-square&logo=c-sharp)
![ADO.NET](https://img.shields.io/badge/ADO.NET-Data%20Access-512BD4?style=flat-square)

- **.NET Framework 4.7.2**: Uygulama çerçevesi
- **Windows Forms**: Kullanıcı arayüzü teknolojisi
- **SQL Server Express**: Veritabanı yönetim sistemi
- **ADO.NET**: Veritabanı erişim teknolojisi
- **C#**: Programlama dili
- **DataGridView**: Veri görüntüleme kontrolü
- **SqlDataAdapter**: Veri adaptörü

### Mimari Yapı

```
┌─────────────────┐
│  Windows Forms  │
│     (UI)        │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│   ADO.NET       │
│  (Data Access)  │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│  SQL Server     │
│   Database      │
└─────────────────┘
```

---

## 📦 Gereksinimler

### Sistem Gereksinimleri

- ✅ **İşletim Sistemi**: Windows 7 veya üzeri
- ✅ **.NET Framework**: 4.7.2 veya üzeri
- ✅ **SQL Server**: Express Edition veya üzeri
- ✅ **RAM**: Minimum 2 GB (önerilen 4 GB)
- ✅ **Disk Alanı**: Minimum 500 MB

### Geliştirme Ortamı

- ✅ **Visual Studio**: 2017 veya üzeri
- ✅ **SQL Server Management Studio (SSMS)**: Veritabanı yönetimi için
- ✅ **.NET Framework 4.7.2 SDK**

### Veritabanı Gereksinimleri

- ✅ SQL Server Express 2014 veya üzeri
- ✅ Windows Authentication veya SQL Server Authentication
- ✅ Veritabanı oluşturma izinleri

---

## 🚀 Kurulum

### 1️⃣ Projeyi İndirin

```bash
# GitHub'dan klonlayın
git clone https://github.com/Kaaner4mir/WindowsFormLabor.git

# Proje dizinine gidin
cd WindowsFormLabor/LibraryTrackingSystem
```

Veya ZIP dosyası olarak indirip açabilirsiniz.

### 2️⃣ Veritabanını Oluşturun

SQL Server Management Studio'yu açın ve aşağıdaki SQL scriptini çalıştırın:

```sql
-- Veritabanını oluştur
CREATE DATABASE BooksDB;
GO

-- Veritabanını kullan
USE BooksDB;
GO

-- Books tablosunu oluştur
CREATE TABLE Books (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Genre NVARCHAR(50),
    Language NVARCHAR(50),
    Publisher NVARCHAR(100),
    PageCount INT,
    PublicationYear INT
);
GO

-- Örnek veri ekle (isteğe bağlı)
INSERT INTO Books (Title, Author, Genre, Language, Publisher, PageCount, PublicationYear)
VALUES 
    ('1984', 'George Orwell', 'Dystopian Fiction', 'English', 'Secker & Warburg', 328, 1949),
    ('To Kill a Mockingbird', 'Harper Lee', 'Fiction', 'English', 'J.B. Lippincott & Co.', 281, 1960),
    ('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction', 'English', 'Charles Scribner''s Sons', 180, 1925);
GO
```

![SQL File Structure](Images/SqlFileStructure.png)

### 3️⃣ Connection String'i Yapılandırın

`Form1.cs` dosyasını açın ve connection string'i kendi SQL Server bilgilerinize göre güncelleyin:

```csharp
// Satır 21'deki connection string'i düzenleyin
SqlConnection _connection = new SqlConnection(@"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True;Encrypt=False");
```

**Önemli Notlar:**

- `YOUR_SERVER_NAME` kısmını kendi bilgisayar adınızla değiştirin
- SQL Server instance adınızı öğrenmek için:
  - SQL Server Management Studio'da bağlantı penceresine bakın
  - Veya Windows'ta `hostname` komutunu çalıştırın
- **Windows Authentication** kullanıyorsanız (önerilen):
  ```csharp
  @"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True;Encrypt=False"
  ```
- **SQL Server Authentication** kullanıyorsanız:
  ```csharp
  @"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=BooksDB;User ID=your_username;Password=your_password;Encrypt=False"
  ```
- **LocalDB** kullanıyorsanız:
  ```csharp
  @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=True;Encrypt=False"
  ```

### 4️⃣ Projeyi Derleyin ve Çalıştırın

1. Visual Studio'da `LibraryTrackingSystem.sln` dosyasını açın
2. `Build > Build Solution` (Ctrl+Shift+B) menüsünden projeyi derleyin
3. `Debug > Start Debugging` (F5) veya `Start Without Debugging` (Ctrl+F5) ile çalıştırın

### 5️⃣ İlk Kullanım

- Uygulama açıldığında veritabanındaki tüm kitaplar otomatik olarak listelenir
- Yeni kitap eklemek için form alanlarını doldurup **Save** butonuna tıklayın
- Mevcut bir kitabı düzenlemek için tablodan seçin ve **Update** butonuna tıklayın

---

## 💾 Veritabanı Yapısı

### Books Tablosu

![Database Structure](Images/DB.png)

| Sütun Adı | Veri Tipi | Nullable | Açıklama |
|-----------|-----------|----------|----------|
| **Id** | INT | ❌ | Primary Key, Identity (Otomatik artan) |
| **Title** | NVARCHAR(200) | ❌ | Kitap başlığı (Zorunlu) |
| **Author** | NVARCHAR(100) | ❌ | Yazar adı (Zorunlu) |
| **Genre** | NVARCHAR(50) | ✅ | Kitap türü |
| **Language** | NVARCHAR(50) | ✅ | Kitap dili |
| **Publisher** | NVARCHAR(100) | ✅ | Yayınevi |
| **PageCount** | INT | ✅ | Sayfa sayısı |
| **PublicationYear** | INT | ✅ | Yayın yılı |

### İlişkiler

- **Primary Key**: `Id` (Identity, otomatik artan)
- **Index**: `Id` üzerinde clustered index

### Veri Tipleri Açıklaması

- **INT**: Tam sayı değerleri için
- **NVARCHAR**: Unicode karakter dizileri için (Türkçe karakter desteği)
- **IDENTITY(1,1)**: Otomatik artan sayı (1'den başlar, 1'er artar)

---

## 📖 Kullanım Kılavuzu

### 🆕 Yeni Kitap Ekleme

1. Form alanlarını doldurun:
   - **Title**: Kitap başlığı (zorunlu)
   - **Author**: Yazar adı (zorunlu)
   - **Genre**: Kitap türü
   - **Language**: Kitap dili
   - **Publisher**: Yayınevi
   - **PageCount**: Sayfa sayısı
   - **PublicationYear**: Yayın yılı
2. **Save** (Yeşil) butonuna tıklayın
3. Başarı mesajını görüntüleyin
4. Kitap listesinde yeni eklenen kitabı görün

> **Not**: ID alanı otomatik olarak oluşturulur ve düzenlenemez.

### ✏️ Kitap Güncelleme

1. DataGridView'den güncellemek istediğiniz kitaba tıklayın
2. Form alanları otomatik olarak doldurulur
3. İstediğiniz alanları düzenleyin
4. **Update** (Sarı) butonuna tıklayın
5. Başarı mesajını görüntüleyin
6. Güncellenmiş bilgileri listede görün

> **Not**: ID alanı boşsa güncelleme yapılamaz.

### 🗑️ Kitap Silme

1. DataGridView'den silmek istediğiniz kitaba tıklayın
2. Kitap bilgileri form alanlarına yüklenir
3. **Delete** (Kırmızı) butonuna tıklayın
4. Onay mesajını görüntüleyin
5. Kitap listeden kaldırılır

> **⚠️ Uyarı**: Silme işlemi geri alınamaz!

### 🔍 Arama Yapma

1. Sağ alttaki **Search** kutusuna arama terimi yazın
2. Sonuçlar anlık olarak filtrelenir
3. Arama şu alanlarda yapılır:
   - ID
   - Başlık (Title)
   - Yazar (Author)
   - Tür (Genre)
4. Arama kutusunu temizleyerek tüm kitapları tekrar görüntüleyin

**Arama Örnekleri:**
- "1984" → ID veya başlıkta "1984" içeren kitaplar
- "Orwell" → Yazar adında "Orwell" içeren kitaplar
- "Fiction" → Türünde "Fiction" içeren kitaplar

### 🧹 Formu Temizleme

- **Clear** (Mavi) butonuna tıklayarak tüm form alanlarını temizleyebilirsiniz
- Yeni kitap eklemek için formu temizlemek yararlıdır

### 📊 Veri Görüntüleme

- Tüm kitaplar DataGridView'de tablo formatında görüntülenir
- Sütunlar otomatik olarak genişletilir
- Tablo salt okunur moddadır (doğrudan düzenleme yapılamaz)
- Bir satıra tıklayarak kitap detaylarını görüntüleyebilirsiniz

---

## 📁 Proje Yapısı

```
LibraryTrackingSystem/
│
├── 📄 Form1.cs                    # Ana form mantığı ve CRUD işlemleri
├── 📄 Form1.Designer.cs          # Form tasarımı ve UI bileşenleri
├── 📄 Form1.resx                 # Form kaynak dosyası
├── 📄 Program.cs                  # Uygulama giriş noktası
├── 📄 App.config                  # Uygulama yapılandırma dosyası
├── 📄 LibraryTrackingSystem.csproj # Proje dosyası
│
├── 📁 Images/                     # Görsel dosyalar
│   ├── 🖼️ DB.png                 # Veritabanı görseli
│   ├── 🖼️ Linq.png               # LINQ görseli
│   ├── 🖼️ SqlFileStructure.png   # SQL yapı görseli
│   └── 🖼️ WF.png                 # Windows Forms görseli
│
├── 📁 Properties/                 # Proje özellikleri
│   ├── 📄 AssemblyInfo.cs        # Assembly bilgileri
│   ├── 📄 Resources.Designer.cs  # Kaynak dosyası designer
│   ├── 📄 Resources.resx         # Kaynak dosyası
│   ├── 📄 Settings.Designer.cs   # Ayarlar designer
│   └── 📄 Settings.settings      # Uygulama ayarları
│
├── 📁 bin/                        # Derlenmiş dosyalar
│   └── 📁 Debug/                  # Debug build çıktıları
│
└── 📁 obj/                        # Geçici derleme dosyaları
    └── 📁 Debug/                  # Debug obj dosyaları
```

### Dosya Açıklamaları

| Dosya | Açıklama |
|-------|----------|
| `Form1.cs` | Ana form sınıfı, tüm iş mantığı burada |
| `Form1.Designer.cs` | Form tasarımı, UI kontrolleri |
| `Form1.resx` | Form kaynak dosyası (ikonlar, görseller) |
| `Program.cs` | Uygulama giriş noktası, Main metodu |
| `App.config` | Uygulama yapılandırma ayarları |
| `LibraryTrackingSystem.csproj` | Proje dosyası, referanslar ve ayarlar |

---

## 🎨 Ekran Görüntüleri

### Ana Form

Uygulama açıldığında tüm kitaplar DataGridView'de listelenir ve form alanları kullanıma hazır hale gelir.

![Windows Forms Application](Images/WF.png)

### Özellikler

- **Modern UI**: Renkli butonlar ve düzenli form yapısı
- **Responsive Design**: Otomatik boyutlandırma
- **User-Friendly**: Kolay kullanımlı arayüz
- **Color-Coded Buttons**: 
  - 🟢 Yeşil: Save (Kaydet)
  - 🟡 Sarı: Update (Güncelle)
  - 🔴 Kırmızı: Delete (Sil)
  - 🔵 Mavi: Clear (Temizle)

### Veritabanı Yapısı

![Database Structure](Images/DB.png)

### SQL Yapısı

![SQL File Structure](Images/SqlFileStructure.png)

---

## 🔧 Geliştirme Notları

### Kod Yapısı

#### Form1.cs
- **Connection Management**: Her işlemde bağlantı açılıp kapanır
- **CRUD Operations**: Create, Read, Update, Delete işlemleri
- **Data Binding**: DataGridView DataTable ile bağlanır
- **Event Handlers**: Buton tıklamaları ve hücre seçimleri için event handler'lar

#### Önemli Metodlar

```csharp
// Kitap listeleme
void List()

// Form alanlarını temizleme
void Clear()

// Kitap ekleme
private void btnSave_Click(object sender, EventArgs e)

// Kitap güncelleme
private void btnUpdate_Click(object sender, EventArgs e)

// Kitap silme
private void btnDelete_Click(object sender, EventArgs e)

// Arama
private void txtSearch_TextChanged(object sender, EventArgs e)
```

### Güvenlik

- ✅ **Parameterized Queries**: SQL injection koruması için parametreli sorgular kullanılır
- ✅ **Input Sanitization**: Arama için özel karakterler temizlenir
- ✅ **Read-Only Grid**: DataGridView salt okunur modda

### Performans

- ✅ **Efficient Queries**: Optimize edilmiş SQL sorguları
- ✅ **DataTable Caching**: Veriler DataTable'da önbelleğe alınır
- ✅ **Connection Management**: Her işlemde bağlantı açılıp kapanır

### İyileştirme Önerileri

- 🔄 Connection string'i `App.config` dosyasına taşınabilir
- 🔄 Try-catch blokları ile hata yönetimi eklenebilir
- 🔄 Veri doğrulama (validation) eklenebilir
- 🔄 Repository pattern kullanılabilir
- 🔄 Unit testler yazılabilir
- 🔄 Using statement'ları ile connection yönetimi iyileştirilebilir
- 🔄 Async/await pattern kullanılabilir
- 🔄 Entity Framework veya Dapper gibi ORM'ler kullanılabilir

---

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Bu projeyi geliştirmek için:

### Nasıl Katkıda Bulunabilirsiniz?

1. ⭐ **Yıldız Verin**: Projeyi beğendiyseniz yıldız vermeyi unutmayın!
2. 🐛 **Hata Bildirin**: Bir hata bulduysanız Issue açın
3. 💡 **Öneride Bulunun**: Yeni özellikler için Issue açın
4. 🔧 **Kod Katkısı**: Pull Request gönderin

### Pull Request Gönderme Adımları

1. Bu repository'yi fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

### Katkı Kuralları

- Kod standartlarına uyun
- Yorum satırları ekleyin
- Test edin
- README'yi güncelleyin (gerekirse)

---

## 📞 İletişim

Sorularınız, önerileriniz veya hata bildirimleri için:

- 📧 **GitHub Issues**: [Issues Sayfası](https://github.com/Kaaner4mir/WindowsFormLabor/issues)
- 👤 **Geliştirici**: Kaaner4mir
- 🔗 **Repository**: [WindowsFormLabor](https://github.com/Kaaner4mir/WindowsFormLabor)

---

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. İstediğiniz gibi kullanabilir ve değiştirebilirsiniz.

```
MIT License

Copyright (c) 2025 Kaaner4mir

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## ⭐ Yıldız Vermeyi Unutmayın!

Bu projeyi beğendiyseniz, yıldız vermeyi unutmayın! ⭐

[![GitHub stars](https://img.shields.io/github/stars/Kaaner4mir/WindowsFormLabor.svg?style=social&label=Star)](https://github.com/Kaaner4mir/WindowsFormLabor)

---

## 🙏 Teşekkürler

Bu projeyi kullandığınız için teşekkür ederiz!

- 📚 Kütüphane yönetimini kolaylaştırmak için geliştirilmiştir
- 🎓 Eğitim amaçlı kullanılabilir
- 💻 Öğrenme ve geliştirme için açık kaynak

---

## 📌 Önemli Notlar

> **⚠️ Production Kullanımı**: Bu uygulama eğitim amaçlı geliştirilmiştir. Production ortamında kullanmadan önce güvenlik ve performans iyileştirmeleri yapılması önerilir.

> **💡 İpuçları**: 
> - Connection string'i güvenli bir şekilde saklayın
> - Düzenli veritabanı yedekleri alın
> - Hata yönetimi ekleyin
> - Loglama mekanizması ekleyin

---

<div align="center">

**⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın! ⭐**

Made with ❤️ by [Kaaner4mir](https://github.com/Kaaner4mir)

*Son Güncelleme: 2025*

</div>

