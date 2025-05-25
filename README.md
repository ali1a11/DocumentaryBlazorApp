# ** Documentary App **  

**En webapplikasjon for å søke, utforske og vurdere dokumentarer.**  

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-WebApp-purple)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

---

## **📌 Om prosjektet**  
Documentary App er en webapplikasjon utviklet med **Blazor (.NET 8)** som lar brukere:  
🔍 **Søke** etter dokumentarer  
⭐ **Vurdere** dokumentarer (kun for registrerte brukere)  
📂 **Bla gjennom kategorier** (Natur, Historie, Teknologi, osv.)  
🎬 **Se detaljer** om dokumentarer (regissør, utgivelsesår, trailer)  
---
🔑 Testbruker
For rask tilgang kan du bruke følgende testkonto:
**E-post**: test@test.com
**Passord**: Test123#

Eller registrer en ny bruker via "Register"-linken.
---

## **🛠️ Teknologier**  
✅ **Backend:**  
- ASP.NET Core 8.0  
- Entity Framework Core (SQLite)  
- REST API med Swagger-dokumentasjon  
- Autentisering med ASP.NET Core Identity  

✅ **Frontend:**  
- Blazor Server  
- Razor-komponenter  
- Responsivt design (Bootstrap + CSS)  

✅ **Verktøy:**  
- Serilog for logging  
- GitHub for versjonskontroll  
- Docker-støtte (klar for deployment)  

---

## **🚀 Kom i gang**  

### **Forutsetninger**  
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)  
- IDE (Visual Studio 2022)  

### **Installasjon**  
1. Klon repoet:  
   ```bash
   git clone https://github.com/ali1a11/DocumentaryBlazorApp.git
   ```
2. Naviger til prosjektmappen:  
   ```bash
   cd DocumentaryBlazorApp
   ```
3. Kjør applikasjonen:  
   ```bash
   dotnet run --launch-profile "https"
   ```
4. Åpne i nettleseren:  
   ```
   https://localhost:7135
   ```

---

## **📂 Prosjektstruktur**  
```
DocumentaryBlazorApp/
│
├── Controllers/          # API-endepunkter
│   ├── DocumentaryApiController.cs
│   └── ReviewApiController.cs
│
├── Data/                 # Database og seeding
│   ├── ApplicationDbContext.cs
│   └── SampleData.cs
│
├── Models/               # Datamodeller
│   ├── Documentary.cs
│   ├── Review.cs
│   └── Language.cs
│
├── Services/             # Business logic
│   ├── DocumentaryService.cs
│   └── ApiClientService.cs
│
├── Components/           # Blazor-komponenter
│   ├── Pages/            # Routbare sider
│   │   ├── Home.razor
│   │   ├── DocDetails.razor
│   │   ├── DocumentaryGrid.razor
│   │   ├── FullListComponent.razor
│   │   └── FilteredListComponent.razor
│   │
│   ├── Account/          # Autentisering
│   └── Layout/           # Hovedlayout
│
├── wwwroot/              # Statiske filer (bilder, CSS)
├── appsettings.json      # Konfigurasjon
└── Program.cs            # Oppstartslogikk
```

---

## **🔍 API-dokumentasjon**  
API-endepunkter dokumentert med **Swagger**:  
📄 [http://localhost:7135/swagger](http://localhost:7135/swagger)  

### **Eksempel-forespørsler**  
**Hent alle dokumentarer:**  
```http
GET /api/DocumentaryApi
```

---

## **📜 Lisens**  
Dette prosjektet er lisensiert under [MIT](LICENSE).  

---

🌐 **GitHub:** [github.com/ali1a11](https://github.com/ali1a11)  

--- 