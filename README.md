# B&B CheckIn Webapplicatie
Nederlandstalige webapplicatie die B&B's toelaat hun kamers online te laten aanbieden door een centrale admin en hun eindgebruikers in de gelegenheid stelt deze te bekijken, te filteren en te boeken.

* Deze applicatie werd gemaakt door Bart Van Gucht en Guy Meuris in het kader van hun eindwerk voor de éénjarige, voltijdse dagopleiding "Software Developer .NET" aan het Syntra te Mechelen.

* De B&B CheckIn app bestaat uit drie delen:
  * Server-side: de adminpagina is gemaakt in Blazor_Server
  * ASP.NETCore 5.0 WebApi: afhandeling van de http-calls uit Client-side.
  * Client-side: de front-end pagina's die de eindgebruiker in staat stelt de app te gebruiken en boekingen te realiseren is gemaakt met Blazor_WASM.

* Om de admin te gebruiken dient men ingelogd te zijn met de volgende gegevens: 
  (hardcoded in de UserRolesConfiguration.cs)
  * Email = "bnbadmin@gmail.com",
  * Password = "BbAdmin123+"

---

## Gedetailleerd overzicht van de 3 onderdelen:

### 1. Het dashboard voor de admin

Het inlogscherm van de admin-page:
<img src="screenshots/adminlogin.jpg" width="800">

* Enkel de admin heeft de juiste privileges om de alle menu-items te bekijken en te bewerken.
---

Overzicht van gemaakte B&B's in de admin-pagina:
<img src="screenshots/adminbnblijst.jpg" width="800">

* Hier kan de admin B&B's gaan toevoegen, wijzigen en verwijderen. 
* Tevens is er een upload-module voor foto's toe te voegen aan de B&B. 
* Er is ook een rechstreekse knop naar alle kamers die verbonden zijn aan deze B&B. 
* Het vermelden waard is het gebruik van RichTextFields bij de beschrijving van de B&B. 
---

"Wijzig Kamer" in de admin-pagina:
<img src="screenshots/adminwijzigkamer.jpg" width="800">

* Admin kan hier alle gegevens van de kamer aanpassen, foto's toevoegen en/of verwijderen.
* Hier ook een RichTextField voor de beschrijving.
---

"Reservatiedetails" in de admin-pagina:
<img src="screenshots/adminreservatiedetails.jpg" width="800">

* Voorbeeld van een B&B-reservatie-formulier: hier kan de admin nog wijzigen gaan toepassen en zelfs de volledige reservatie gaan annuleren of aangeven dat de klant niet is komen opdagen.
---

### 2. De WebAPI

Overzicht van alle calls in de WebAPI:
<img src="screenshots/webapicalls.jpg" width="800">

* Overzicht van alle methodes die in de APi zitten gecodeerd. Ongeveer de helft worden effectief aangesproken, de andere helft zijn voor toekomstige functionaliteiten.
---

"BnBGetAll"-call in de WebAPI:
<img src="screenshots/webapibnbgetall.jpg" width="800">

* Voorbeeld van de API in werking bij het opvragen van een lijst van alle B&B's.
---

### 3. De frontend voor de eindgebruiker

"User Login" in de Client-side:
<img src="screenshots/clientlogin.jpg" width="800">

* Inlogscherm voor de eindgebruiker (die zich ook eerst dient te registreren op de registratiepagina als hij/zij nog geen inlogcode heeft).
* Net zoals bij de inlogpagina voor de admin hebben we hier gebruikt gemaakt van de in ASP.Net ingebouwde Identity Account voor de de authenticatie en authorisatie.
* Vervolgens hebben we ook 'roles' toebedeeld: 'admin', 'user' en 'visitor' (de laatste momenteel nog niet in gebruik).
---

"Filtering zoekresultaten" in de Client-side:
<img src="screenshots/clientfilteringbnb.jpg" width="800">

* De eindgebruiker kan B&B's zoeken op datum en op (Vlaamse) provincie. Onderaan het beeld staat een overzicht van de aangeboden faciliteiten.
* Dit is bedoeld als visuele ondersteuning bij het gebruik van de pictogrammen doorheen de applicatie. (Plan voor de volgende versie is om de faciliteiten aan specifieke B&B's en kamers te linken, zodat de pictogrammen zichtbaar worden op de desbetreffende detail-pagina's. Wegens tijdsgebrek hebben we dit niet in deze eerste versie volledig kunnen uitwerken.)
---

"Zoekresultaat B&B" in de Client-side:
<img src="screenshots/clientbnbdetails.jpg" width="800">

* Na de eerste filtering krijgt de eindgebruiker het zoekresultaat te zien van alle B&B's die vrije kamers hebben in die periode en die in die specifieke provincie gelegen zijn. (Er kan ook gezocht worden op 'alle provincies'.) 
* Naast de B&B-details is er ook een caroussel met alle foto's die bij die specifieke B&B horen.
* Je kan van hier ook makkelijk doorklikken naar de lijst van kamers die bij deze B&B horen.
* Bovenaan kan je de provincie nog aanpassen indien gewenst. (De data zijn op deze pagina niet manipuleerbaar, aangezien dit (in deze versie) geen effect heeft op welke B&B's je te zien krijgt. Je krijgt steeds alle B&B's uit de gekozen provincie te zien.) 
---

"Overzicht kamers bij specifieke B&B" in de Client-side:
<img src="screenshots/clientkamerlijst.jpg" width="800">

* Vervolgens krijgt de eindgebruiker een gedetailleerd overzicht van alle kamers die bij een specifieke B&B horen met alle informatie over elke kamer apart.
* De aangegeven prijs past zich aan ten opzichte van de opgegeven data 'Incheckdatum' en 'Uitcheckdatum'. De data zijn op deze pagina WEL te wijzigen, want als een bepaalde kamer reeds verhuurd is op een specifieke datum, moet de eindgebruiker nu wel de verblijfsdata kunnen aanpassen naar een vrij moment. 
* Naast de kamer-details is er ook een caroussel met alle foto's die bij die specifieke kamer horen.
* Je kan van hier ook makkelijk doorklikken naar het reservatieformulier of je kan teruggaan naar de lijst van kamers. 
* !Opgelet: indien de eindgebruiker nog niet is ingelogd, zal de eindgebruiker worden gevraagd om eerst in te loggen en/of te registreren. Enkel INGELOGDE gebruikers zijn gemachtigd om een kamer te boeken!
---

"Kamerdetails" in de Client-side:
<img src="screenshots/clientkamerdetails.jpg" width="800">

* Op het reservatieformulier ziet de eindgebruiker nog eens alle details van de kamer die hij/zij wenst te boeken.
* Aan de rechterzijde staat vervolgens het invulformulier: dit zal alle gegevens van de klant reeds bevatten als die is ingelogd ondertussen.
* Wanneer de eindgebruiker op 'Reserveren' drukt, wordt hij/zij naar de betalingspagina geleid.
---

"User Stripe betaling" in de Client-side:
<img src="screenshots/clientbetaling.jpg" width="800">

* Hier moet de eindgebruiker zijn/haar betalingsgegevens invoeren om de reservatie te bevestigen. (Voorlopig een dummy-module!) Pas na bevestiging van betaling zal de orderstatus van de reservatie veranderen naar "Gereserveerd" en zal de kamer tijdens die data in de lijst staan als 'verhuurd'.

---

"E-mail payment confirmation" in de Client-side:
<img src="screenshots/email.jpg" width="800">

* Na bevestiging van de betaling (en dus de reservatie.) wordt er in naam van B&BCheckIn automatisch een bevestigingsmail verstuurd naar de klant.
---


