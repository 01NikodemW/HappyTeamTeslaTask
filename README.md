# HappyTeamTeslaTask
## Rozwiązanie zadania rekrutacyjnego.

1. Uruchomienie programu

Aby uruchomić program wystarczy wykonać polecenie **docker-compose up**

2. Założenia dotycząca zadania

Jako że zadanie zostało luźno zdefiniowane przyjąłem kilka założeń w celu stworzenia rozwiązania

- Samochody wypożyczane są na pełne dni
- Każdy samochód zawiera cenę wypożyczenia na jeden dzień, przez co jestem w stanie wyznaczyć cenę całkowitą wypożyczenia
- Samochód może zostać wypożyczony z dowolnej lokalizacji oraz zwrócony do dowolnej lokalizacji
- Możliwe jest wypożyczenie samochodu na jeden dzień


3. Podejście w rozwiązaniu zadania

Pierwszym krokiem jaki poczyniłem było przeanalizowanie treści zadania, określenie założeń wyżej wymienionych. Po wykonaniu tych czynności utworzyłem w programie draw.io schemat bazy danych, forma graficzna pozwoliła mi upewnić się, że mój tok myślenia oraz cały schemat bazy danych ma rację bytu.


![My image](https://github.com/01NikodemW/HappyTeamTeslaTask/blob/main/database-diagram.png)

Po wykonaniu tych czynności przeszedłem do kodowania rozwiązania. Utworzyłem nowy projekt, w którym zacząłem od tworzenia bazy danych z wykorzystaniem Entity Framework. Rozpocząłem od elementów "stałych" jak kraje, samochody i lokalizacje. Stworzyłem funkcję seedującą dane, gdyż nie miałem ich skąd pobierać. Utworzyłem kontrolery dla tych enepointów które przy użyciu odpowiednich serwisów sięgały po te dane. Następnie przeszedłem do utworzenia użytkownika w bazie danych. Podczas rejestracji użytkownika zabezpieczałem jego hasło najpierw odpowiednio je walidując a następnie haszując wbudowaną funkcją. Do logowania wykorzystałem generację tokenów JWT, które są wykorzystywane podczas wykonywania enepointów zawierających dekorator [Authorize].
Na samym końcu utworzyłem tabelę przechowującą rezerwację, której każdy rekord zawiera odniesienie do użytkownika, pojazdu, lokalizacji wypożyczenia i zwrotu.  

4. Dodatkowe elementy rozwiązania

W ramach rozwiązania zadania utworzyłem również front aplikacji w technologi React, jako bibliotekę komponentów wykorzystałem Materiał UI, który pozwolił mi w szybki sposób zbudować UI aplikacji. Dodatkowo do wszelkie formularze są obsługiwane z wykorzystaniem formika. Do zarządzania stanem nie wykorzystałem żadnej zewnętrznej biblioteki jak redux bo uznałem, że byłby do przerost formy nad treścią. Dokonałem również konteneryzacji aplikacji (Ustawienie Thread.Sleep(15_000) w klasie Program.cs spowodowane było zbyt szybkim startowanie kontenera z sql server i niemocą poczekania na niego w docker compose za pomocą zależności)

