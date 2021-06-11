# B&B CheckIn Webapplicatie
Nederlandstalige webapplicatie die B&B's toelaat hun kamers online te laten aanbieden door een centrale admin en hun eindgebruikers in de gelegenheid stelt deze te bekijken, te filteren en te boeken.

Deze applicatie werd gemaakt door Bart Van Gucht en Guy Meuris in het kader van hun eindwerk voor de éénjarige, voltijdse dagopleiding "Software Developer .NET" aan het Syntra te Mechelen.

De B&B CheckIn app bestat uit drie delen:
	* Server-side: de adminpagina is gemaakt in Blazor_Server
	* ASP.NETCore 5.0 WebApi: afhandeling van de http-calls uit Client-side.
	* Client-side: de front-end pagina's die de eindgebruiker in staat stelt de app te gebruiken en boekingen te realiseren is gemaakt met Blazor_WASM.

OM de admin te gebruiken dient men ingelogd te zijn met de volgende gegevens: 
(hardcoded in de UserRolesConfiguration.cs)
Email = "bnbadmin@gmail.com",
Password = "BbAdmin123+"

### Gedetailleerd overzicht
* Het inlogscherm van de admin-page:
<img src="screenshots/adminlogin.jpg" width="600">

* Overzicht van gemaakte B&B's in de admin-pagina:
<img src="screenshots/adminbnblijst.jpg" width="600">

* "Wijzig Kamer" in de admin-pagina:
<img src="screenshots/adminwijzigkamer.jpg" width="600">

* "Reservatiedetails" in de admin-pagina:
<img src="screenshots/adminreservatiedetails.jpg" width="600">

* Overzicht van alle calls in de WebAPI:
<img src="screenshots/webapicalls.jpg" width="600">

* "BnBGetAll"-call in de WebAPI:
<img src="screenshots/webapibnbgetall.jpg" width="600">

* "User Login" in de Client-side:
<img src="screenshots/clientlogin.jpg" width="600">

* "Filtering zoekresultaten" in de Client-side:
<img src="screenshots/clientfilteringbnb.jpg" width="600">

* "Zoekresultaat B&B" in de Client-side:
<img src="screenshots/clientbnbdetails.jpg" width="600">

* "Overzicht kamers bij specifieke B&B" in de Client-side:
<img src="screenshots/clientkamerlijst.jpg" width="600">

* "Kamerdetails" in de Client-side:
<img src="screenshots/clientkamerdetails.jpg" width="600">

* "User Stripe betaling" in de Client-side:
<img src="screenshots/clientbetaling.jpg" width="600">

* "E-mail payment confirmation" in de Client-side:
<img src="screenshots/email.jpg" width="600">


