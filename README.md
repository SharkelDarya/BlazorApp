<p align="center">
      <img src="https://i.ibb.co/BnkWthD/Blazor-T5-dark-1200x303.png" alt="Project Logo" width="746">
</p>

<p align="center">
   <img src="https://img.shields.io/badge/Engine-VS%20Community%202022-8B00FF" alt="Engine">
   <img src="https://img.shields.io/badge/Version-17.5.4-0000ff" alt="Visual Studio Version">
   <img src="https://img.shields.io/badge/DataBase-SQL%20Server%20MS%2019.1-FFA500" alt="DataBase Version">
</p>

## About

Sklep internetowy z dynamicznym wyświetlaniem produktów w zależności od wybranej kategorii. Witryna implementuje funkcję filtrowania produktów według kategorii, dając użytkownikowi możliwość wyboru konkretnej kategorii na pasku nawigacyjnym.

Wykorzystany Blazor WebAssembly do budowy strony klienckiej aplikacji. Wykorzystując język C# i .NET. Technologia ASP.NET Core wykorzystana jako backend w celu zapewnienia przetwarzania zapytań, interakcji z bazą danych i dostarczania danych po stronie klienta aplikacji. Do zarządzania bazą danych, w której przechowywane są informacje o produktach wykorzystana aplikacja SQL Server MG.
## Documentation

### Classes
- **-** **`ApplicationDBContext.cs`** - Zapewnia kontekst bazy danych dla projektu, wykorzystując Entity Framework Core do interakcji z tabelami Products i Accounts. Plik definiuje również format przechowywania danych dla kolumny Price w tabeli Products.
- **-** **`AccountService.cs`** - Interakcja z tabelą Accounts w bazie danych. Klasa zawiera metody do pobierania kont, dodawania nowego konta i pobierania konta według jego identyfikatora przy użyciu kontekstu bazy danych ApplicationDBContext.
- **-** **`ProductsService.cs`** - Interakcja z tabelą Products w bazie danych. Klasa zawiera metody do pobierania wszystkich produktów, dodawania nowego produktu i pobierania listy produktów według określonej kategorii przy użyciu bazy danych.
- **-** **`Account.cs`** - Model danych dla kont służy do definiowania wymaganych pól, ich formatu i komunikatów o błędach walidacji.
- **-** **`Products.cs`** - Model danych dla produktów z adnotacją [Key].
- **-** **`Products.cs`** - Model danych dla produktów z adnotacją [Key].

### Razor Components
- **-** **`Category.razor`** - 

## Developers

- Darya Sharkel (https://github.com/SharkelDarya)
