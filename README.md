# Sanal Tarihçim 📚

> **ASP.NET Core MVC** tabanlı bir tarih kitabı e-ticaret uygulaması. Tarih kategorisindeki kitapları listeler; kullanıcıların sepete kitap ekleyip simüle edilmiş bir ödeme süreci tamamlamasına olanak tanır.

---

## ⚠️ Önemli Not

> **[!IMPORTANT]**
> Bu proje yalnızca **eğitim ve portföy amaçlı** geliştirilmiştir. Gerçek bir ödeme altyapısı **içermemektedir**. Ödeme adımı simülasyon amaçlıdır; herhangi bir finansal işlem gerçekleşmez.

---

## ⚠️ Eski .NET Sürümleri Hakkında Önemli Not

> **[!CAUTION]**
> Eski veya eksik .NET SDK kurulumları uygulamanın çalışmasına engel olmaktadır. Bilgisayarınızda uyumsuz bir sürüm bulunuyorsa lütfen tamamen kaldırın ve **.NET 10.0** sürümünü yükleyin. Bunu yapmadığınız takdirde Sanal Tarihçim çok yüksek ihtimalle çalışmayacaktır.

---

## 📋 Özet

**Sanal Tarihçim**, tarih kitaplarını listeleyen, kullanıcıların sepete kitap ekleyip simüle edilmiş ödeme akışını tamamlayabildiği bir ASP.NET Core MVC web uygulamasıdır. Bu uygulama kesinlikle **gerçek bir satış platformu değildir** ve kredi kartı işlemlerinde/gerçek hayatta herhangi bir ücrete sebep **olmayacaktır**.

Proje şu konuları kapsar:
- MVC mimarisi (Model - View - Controller)
- Razor Views ile dinamik sayfa oluşturma
- Session tabanlı sepet yönetimi
- Statik ürün verisi ile çalışan kitap listeleme sistemi

> **[!NOTE]**
> Windows, macOS veya Linux işletim sistemlerinde geliştirici ortamında çalıştırmanız mecburidir.

---

## 🔒 Virüs & Veri Sızıntısı & Ödeme İşlemleri

Program açık kaynak kodlu (HTML, CSS, C#, JavaScript) olduğundan **tüm kodu görüp inceleyebilirsiniz**. Bazı kullanıcılar ödeme sayfasında gerçek veri istenip istenmediğini sorabilir; ancak bu `.cshtml` dosyalarının yapısından dolayı yanlış bir izlenim verebilmektedir — bu formlar yalnızca simülasyonu etkiler. İstemeyen ve güvenmeyen kullanıcılar kullanmak zorunda değildir, herkesin kendi seçimidir.

> **[!IMPORTANT]**
> Kodların içinde ya da projeyi incelerken karşılaşacağınız sepet tutarları veya ödeme adımları sizi korkutmasın. Bu, tamamen ASP.NET Core MVC yapısını ve e-ticaret iş akışını göstermek amacıyla tasarlanmış bir projedir. Geliştirici olan Deniz, bu projeyi tamamen ücretsiz ve açık kaynak kodlu şekilde [GitHub - Sanal Tarihçim](https://github.com/Denizbiyonss/sanal-tarihcim) repository'sinde paylaşmaktadır. Bu projeden hiçbir ticari gelir elde edilmemektedir.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|-----------|----------|
| ASP.NET Core (.NET 10) | Web framework |
| Razor Views (.cshtml) | Sunucu taraflı şablon motoru |
| HTML / CSS / JS | Frontend |
| C# | Backend iş mantığı |

---

## 🚀 Sanal Tarihçim'i Kullanmak

Sanal Tarihçim'i kullanmak için **iki yöntem** bulunmaktadır.

- **Visual Studio (IDE) ile kullanma:** Yalnızca bir kez projeyi derleyip ardından IIS Express veya Kestrel üzerinden otomatik olarak çalışır.
- **Terminal (CLI) ile kullanma:** Terminal üzerinden her defasında `dotnet run` komutu ile başlatmanız gerekir (terminal penceresi kapatıldığında sunucu durur).

> **[!NOTE]**
> İndirdiğiniz proje klasörünü çıkardığınız konumdan **taşımayın**. Yapı `appsettings.json` ayarlarını ve proje yolunu kullanacağından dosyaları taşırsanız bağlantı sorunları yaşanabilir. (Tavsiyem sizi rahatsız etmeyecek bir konuma çıkarmanız. Örneğin, `C:\SanalTarihcim\`.)

---

### 🖥️ Visual Studio ile Kullanma *(Hızlı Başlatma — Otomatik çalışır)*

1. Repoyu bilgisayarınıza indirin.
2. ZIP dosyasını herhangi bir dizine çıkarın.
3. `SanalTarihcim.csproj` dosyasına çift tıklayarak **Visual Studio** ile açın.
4. Üst menüden **▶ Start** butonuna basın.
5. Tarayıcı, proje derlendiğinde otomatik olarak açılacak ve uygulama başlayacaktır.

> **[!NOTE]**
> Uygulamayı durdurmak için Visual Studio'daki **■ Stop** butonuna basmanız yeterlidir.

---

### 💻 Terminal (CLI) ile Kullanma *(Tek seferlik — pencere kapatıldığında sona erer)*

Bir komut penceresi açılır ve uygulama çalışmaya başlar; pencere kapatıldığında sunucu durur.

1. Repoyu klonlayın:
   ```bash
   git clone https://github.com/Denizbiyonss/sanal-tarihcim.git
   cd sanal-tarihcim
   ```

2. Bağımlılıkları yükleyin:
   ```bash
   dotnet restore
   ```

3. Uygulamayı başlatın:
   ```bash
   dotnet run
   ```

4. Tarayıcınızda açın:
   ```
   http://localhost:5000
   ```

> **[!NOTE]**
> `dotnet run` komutu ile çalıştırıldığında hem bilgisayarınız yeniden başlatıldığında uygulamayı elle açmanız gerekecek, hem de terminal penceresi kapatıldığında uygulama devre dışı kalacaktır.

---

## 📁 Proje Yapısı

```
sanal-tarihcim/
├── Controllers/        → MVC Controller'ları (kitap listesi, sepet, ödeme)
├── Models/             → Veri modelleri (Book, CartItem vb.)
├── Views/              → Razor şablonları (.cshtml sayfaları)
├── wwwroot/            → Statik dosyalar (CSS, JS, resimler)
├── Properties/         → Uygulama özellikleri
├── Program.cs          → Uygulama giriş noktası ve servis konfigürasyonu
├── SanalTarihcim.csproj → Proje dosyası
├── appsettings.json    → Uygulama ayarları
└── appsettings.Development.json → Geliştirme ortamı ayarları
```

---

## 📖 Özellikler

- Tarih kitaplarını listeleme
- Kitap detay sayfası
- Sepete kitap ekleme / çıkarma
- Session tabanlı sepet yönetimi *(giriş gerektirmez)*
- Simüle edilmiş ödeme / sipariş tamamlama ekranı

---

## 🔧 Sık Karşılaşılan Sorunlar

**`dotnet` komutu tanınmıyor / SDK bulunamadı hatası:**
Bilgisayarınızda uygun .NET SDK yüklü değil. [Buradan](https://dotnet.microsoft.com/download) .NET 10 SDK'yı indirip kurabilirsiniz.

**Port zaten kullanımda hatası:**
`Program.cs` dosyasından port numarasını değiştirebilir ya da çakışan uygulamayı kapatabilirsiniz.

**"Dosya yolu bulunamadı" hatası:**
Bu hata proje klasörünü farklı bir konuma taşımanız halinde ortaya çıkar. Projeyi orijinal konumuna geri taşıyın veya sıfırdan klonlayıp tekrar çalıştırın.

---

## ⭐ Bağış ve Destek

Bu projeyi kullanmak tamamen **ücretsizdir**. Kullanımından herhangi bir ticari gelir elde edilmemektedir. Eğer projeye destek olmak isterseniz GitHub üzerinden **⭐ yıldız** verebilirsiniz — bu en büyük motivasyon kaynağıdır.

---

## ⚖️ Yasal Uyarı

> **[!IMPORTANT]**
> Bu uygulamanın kullanımından doğan her türlü yasal sorumluluk kullanan kişiye aittir. Uygulama yalnızca **eğitim ve araştırma amaçları** ile yazılmış ve düzenlenmiş olup; bu uygulamayı bu şartlar altında kullanmak ya da kullanmamak kullanıcının kendi seçimidir. Bu proje, bilgi paylaşımı ve kodlama eğitimi amaçlarıyla açık kaynak olarak paylaşılmıştır.

---

<div align="center">
  <sub>Built with ❤️ using ASP.NET Core MVC · <a href="https://github.com/Denizbiyonss">Denizbiyonss</a></sub>
</div>
