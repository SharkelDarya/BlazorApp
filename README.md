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

### Razor Components
- **-** **`Category.razor`** - Strona kategorii produktów, gdzie produkty są dynamicznie ładowane w zależności od wybranej kategorii. Wykorzystuje usługę ProductsService do pobierania danych produktów i dynamicznie konwertuje nazwy kategorii na odpowiednie ciągi URL dla zapytań do bazy danych.
- **-** **`Index.razor`** - Strona główna z górnym menu, logo i paskiem bocznym, zapewniając linki do różnych kategorii produktów. Zawiera również komponent ProductList, odpowiedzialny za dynamiczne wyświetlanie produktów w głównej części strony.
- **-** **`Login.razor`** - Strona logowania z formularzem do wprowadzania loginu i hasła. *Funkcjonalność logowania nie została jeszcze zaimplementowana*.
- **-** **`Registration.razor`** - Strona rejestracji z formularzem do wprowadzania e-mail, hasło, lokalizacja i numer telefonu. Korzystając z walidacji danych i AccountService, przesywa formularz i tworzy nowe konto użytkownika, po czym przekierowuje użytkownika na stronę logowania.
- **-** **`ProductList.razor`** - Wyświetla produkty. Po pobraniu danych komponent wyświetla informacje o każdym produkcie, w tym obraz, nazwę, ocenę, cenę, opis i kategorię. Jeśli dane nie zostały załadowane, wyświetlany jest komunikat "Loading...".
## Developers

- Darya Sharkel (https://github.com/SharkelDarya)
