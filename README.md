# 📝 ASP.NET Core ile API Tabanlı Blog Projesi

BTK Akademi'de **Murat Yücedağ** tarafından verilen **"ASP.NET Core ile API Tabanlı Yapay Zeka Atölyesi"** kursunda geliştirilen blog projesidir.

> ⚠️ **Bu proje eğitim amaçlıdır.** Kurs devam etmektedir ve proje aktif olarak geliştirilmektedir.

## 🏗️ Proje Yapısı

| Proje | Açıklama |
|-------|----------|
| `MYBtkAkademiBlog.WebApi` | ASP.NET Core Web API — Backend servisleri ve veritabanı işlemleri |
| `MYBtkAkademiBlog.WebUI` | ASP.NET Core MVC — Kullanıcı arayüzü |

## 🛠️ Kullanılan Teknolojiler

- ASP.NET Core Web API
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Swagger

## 📦 Entity'ler

- `Category` — Blog kategorileri
- `Article` — Blog yazıları
- `About` — Hakkında bilgileri
- `Contact` — İletişim bilgileri
- `Employee` — Çalışan bilgileri
- `TradingVideo` — Video içerikleri

## 🚀 Kurulum

1. Repo'yu klonlayın:
   ```bash
   git clone https://github.com/<ilterisAykol>/MYBtkAkademiBlog.git
   ```
2. `appsettings.json` dosyasındaki connection string'i kendi SQL Server bilgilerinize göre güncelleyin.
3. Migration'ları uygulayın:
   ```bash
   dotnet ef database update --project MYBtkAkademiBlog.WebApi
   ```
4. Projeyi çalıştırın:
   ```bash
   dotnet run --project MYBtkAkademiBlog.WebApi
   dotnet run --project MYBtkAkademiBlog.WebUI
   ```

## ⚖️ Lisans & Telif Hakkı Bildirimi

Bu projede kullanılan **frontend template** (HTML/CSS/JS dosyaları, görseller ve tasarım varlıkları) **ücretli bir ticari template'tir** ve lisansı orijinal sahibine aittir. Bu dosyaları kopyalama, dağıtma veya ticari amaçla kullanma hakkı bu repo ile verilmemektedir.

Proje yalnızca **eğitim ve kişisel öğrenme** amaçlıdır.

## 📚 Kurs Bilgisi

- **Kurs:** ASP.NET Core ile API Tabanlı Yapay Zeka Atölyesi
- **Eğitmen:** Murat Yücedağ
- **Platform:** BTK Akademi
- **Durum:** 🔄 Devam ediyor

---

*Bu repo, kursta öğrenilen konuların pratik uygulaması olarak oluşturulmuştur.*
