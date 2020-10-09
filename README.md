# Meddelandecentralen
Jag har valt att göra en chatt-applikation där alla anslutna medarbetare kan skriva meddelanden till alla.
Applikationen ska byggas med hjälp av ramverket Blazor Server för server-API:et och Blazor WebAssembly för klientgränssnittet.

---

Jag har planerat för att applikationen ska innehålla föjande funktionalitet:

* Ska använda ramverket SignalR för realtidskommunikation mellan klientgränssnittet och server-side API:et
* Ska ha en navigationsmeny som länkar till en chatt-sida och en sida för viktiga meddelanden, samt ska en "tom" länk finnas till larm-sidan
* Simulering av in/ut -loggning där vald användare lagras till local storage
* På chatt-sidan ska man kunna:
  * Se alla meddelanden inkl. vem som skrivit och när (datum och tid)
  * Skriva ett meddelande
  * Skapa en undertråd till ett meddelande
  * Markera ett meddelande som viktigt
  
* På sidan för viktiga meddelanden ska man kunna:
  * Se alla meddelanden som är markerade som viktiga
  * Skapa (eller skriva i befintlig) undertråd för inlägget
  * Avmarkera inlägg som inte längre är viktiga


