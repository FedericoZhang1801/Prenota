Pagina ASP.NET per prenotazioni tramite Database e Form

Creata la classe Utente.cs per impostare i parametri da immettere nel form della View Prenota.cshtml
con l'utente ottenuto tramite il metodo POST della view in HomeController, creiamo un Database db e carichiamo gli utenti registrati
Una volta Registrato l'utente Stampiamo una pagina di conferma della prenotazione tramite la view Prenotato.cshtml

ASP.NET è un Framework che permette di creare pagine web (utilizzando HTML, JS e CSS) 
viene presentato con un Controller(HomeController) che tramite dei metodi Action gestisce le View, Pagine .cshtml che l'utente puo manipolare e gestire tramite i models, file classe in C#

Si usano le Librerie di Dotnet EntityFramework ( In questo progetto con la Target Version 8.0.0)
Comandi per Aggiungere al progetto le librerie di Entity Framework, SQLIte e Identity.

Verificare la versione di .NET e installare la Versione di Dotnet EFC dipendentemente dalla versione target
dotnet add package Microsoft.EntityFrameworkCore -v x.0.0
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore  -v x.0.0
dotnet add package Microsoft.EntityFrameworkCore.Sqlite -v x.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design -v x.0.0

Installare i tools di ef (della giusta versione) usando questo comando
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef --version 8.0.0

Visualizzo l’elenco dei tool installati
dotnet tool search ef

Visualizzo la versione dei tool di ef installata
dotnet ef --version
