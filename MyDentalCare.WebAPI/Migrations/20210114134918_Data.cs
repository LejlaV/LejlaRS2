using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDentalCare.WebAPI.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresa_GradId",
                table: "Adresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Clanak_KategorijaId",
                table: "Clanak");

            migrationBuilder.DropForeignKey(
                name: "FK_Clanak_KorisnikId",
                table: "Clanak");

            migrationBuilder.DropForeignKey(
                name: "FK_Grad_DrzavaId",
                table: "Grad");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloga_UlogaId",
                table: "KorisnikUloga");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicinskiKarton_PacijentId",
                table: "MedicinskiKarton");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjena_ClanakId",
                table: "Ocjena");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjena_PacijentId",
                table: "Ocjena");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_DijagnozaId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_KorisnikId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_LijekId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_MedicinskiKartonId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_RezervacijaId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_PacijentId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_UslugaId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_StomatoloskaOrdinacija_AdresaId",
                table: "StomatoloskaOrdinacija");

            migrationBuilder.InsertData(
                table: "Dijagnoza",
                columns: new[] { "DijagnozaId", "Naziv" },
                values: new object[,]
                {
                    { 1, "paradentoza" },
                    { 2, "karijes" },
                    { 1009, "snimanje" },
                    { 1010, "izbjeljivanje" }
                });

            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "DrzavaId", "Naziv" },
                values: new object[] { 1, "Bosna i Hercegovina" });

            migrationBuilder.InsertData(
                table: "Kategorija",
                columns: new[] { "KategorijaId", "Naziv" },
                values: new object[,]
                {
                    { 1, "Opća stomatologija" },
                    { 2, "Porodična stomatologija" },
                    { 1002, "Estetska stomatologija" },
                    { 1003, "Parodontologija" },
                    { 1006, "Ortodoncija" },
                    { 1007, "Oralna hirurgija" }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "KorisnikId", "BrojTelefona", "DatumRodjenja", "Email", "Ime", "KorisnickoIme", "PasswordHash", "PasswordSalt", "Prezime" },
                values: new object[] { 2002, "38762598895", new DateTime(1998, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "lejla.vejzovic@edufit.ba", "Lejla", null, "rVJJ78RFz9/58/wfAx5L7lka+0w=", "2qm2bCZGHu5ani8g10pmQA==", "Vejzovic" });

            migrationBuilder.InsertData(
                table: "Lijek",
                columns: new[] { "LijekId", "Naziv", "Uputstvo" },
                values: new object[,]
                {
                    { 1, "paracetamol", "Koriste se za ublažavanje blage do umjerene boli i snižavanje povišene tjelesne temperature. Lijek je namijenjen za kratkotrajnu primjenu u odraslih i djece starije od 6 godina (tjelesne težine iznad 21 kg)." },
                    { 1002, "Afobazol", "Preporučuje se uporaba lijeka tri puta dnevno, 10 mg (1 tableta). Ako pacijent doživi jake negativne osjećaje, dopušteno je da se ova doza udvostruči. Lijek treba nastaviti najmanje 7 dana. Prosječni tijek liječenja je 2-4 sedmice." },
                    { 1003, "Glicin", "Prema uputama, ovaj lijek je potrebno uzimati 1 tabletu 2 ili 3 puta dnevno. U isto vrijeme potrebno ju je otopiti ili slomiti. Trajanje terapije je 2-4 tjedna. Za bebe do 3 godine, doza se smanjuje 2 puta." }
                });

            migrationBuilder.InsertData(
                table: "Pacijent",
                columns: new[] { "PacijentId", "BrojTelefona", "DatumRegistracije", "Email", "Ime", "KorisnickoIme", "PasswordHash", "PasswordSalt", "Prezime" },
                values: new object[,]
                {
                    { 2012, "635823336", null, "testPacijent@outlook.com", "test", "testPacijent", "YMjPSdqRMWfDshfWOZOotTf032E=", "ytubYZVEbxq2c7u9sozriA==", "Pacijent" },
                    { 2009, "625897431", null, "azraopijac@hotmail.com", "Azra", "AzraO", "ArIYMMigRHZw/YT30VDzvcTV1cQ=", "X4s1DH5UTTtGdMokWQvnKQ==", "Opijac" }
                });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "UlogaId", "Naziv" },
                values: new object[] { 1, "administrator" });

            migrationBuilder.InsertData(
                table: "Usluga",
                columns: new[] { "UslugaId", "Cijena", "Naziv" },
                values: new object[,]
                {
                    { 2, 30m, "popravak zuba" },
                    { 1002, 35m, "stavljanje plombe" },
                    { 2006, 250m, "ordinacijsko beljenje laserom" },
                    { 2008, 30m, "pregled specijaliste" },
                    { 2009, 15m, "RTG Snimak" }
                });

            migrationBuilder.InsertData(
                table: "Clanak",
                columns: new[] { "ClanakId", "DatumObjave", "KategorijaId", "KorisnikId", "Naslov", "Sadrzaj", "Slika" },
                values: new object[,]
                {
                    { 2025, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1006, 2002, "Folije za ispravljanje zuba", "Folije za ispravljanje zuba (alajneri) čine set providnih folija za zube kojima na komforan način možete rešiti nepravilan položaj zuba. Pacijenti ih danas vrlo rado biraju zbog mogućnosti da isprave anomalije svojih zuba, a da sam proces ne bude vidljiv. Ponekad ih nazivaju i nevidljivom fiksnom protezom.  Šta su to folije za ispravljanje zuba? Ove folije služe da blagom silom deluju na zube i na taj način ih pomeraju. Napravljene su od tanke, providne plastike, glatke na dodir i udobne za nošenje.Kome je namenjen ovaj način ispravljanja zuba? Zbog toga što folije na zubima nisu sve vreme i što je pritisak na zube umeren, ovom metodom je moguće ispraviti samo blaže i srednje teške nepravilnosti zuba. Još jedna primena ovih folija može biti u kombinaciji sa fiksnom protezom, kada se neka teža anomalija najpre nekoliko meseci tretira fiksnom protezom, a zatim se terapija dovršava folijama.", null },
                    { 2008, new DateTime(2020, 12, 3, 20, 34, 40, 0, DateTimeKind.Unspecified), 1, 2002, "Električne četkice za zube – dobar ili loš izbor?", "Električna četkica za zube je zapravo četkica za zube koja pravi automatske pokrete i oscilacije, a izuzetno pomaže boljem čišćenju zubne površine. Ovi pokreti su posledica elektromotora koji se može pokretati pomoću baterija. Različite frekvencije oscilacija i brzina zavise od toga kakvog je kapaciteta električna četkica za zube. Kome god je padalo na pamet da običnu četkicu za zube zameni električnom, savetujemo da to i uradi i testira da li mu odgovara.", null },
                    { 2012, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 2, 2002, "Mlečni zubi i sve što treba znati o njima", "Ovaj blog posvećen je mnogim odgovorima na pitanja koja se tiču zuba, rasta zuba kod deteta, menjanja zuba kod deteta, ali i kvarova na mlečnim zubima. Nicanje zuba Ovaj proces muči mnoge koji zube shvataju podrazumevanom vrednošću, a kao i većina ne pamte vreme kada su im nicali prvi zubiDa se ne bi oštetile desni, poželjno je da ugao između zuba i desni i četkice bude 45 stepeni. Kružnim pokretima čisteći zub po zub, a potom i četkanjem cele površine, četkaju se svi zubi. Samo je potrebno odreagovati na vreme. Međutim, ukoliko dođe do kvarenja ostalih zuba i širenja karijesa, to može napraviti infekciju, koja rezultira vađenjem zuba i lošim formiranjem vilične kosti. Zbog toga što se naredni zub koji treba da nikne povlači na mesto onog koji fali, potrebno je ugraditi distancer. Ukoliko se to ne uradi, susedni zubi mogu zauzeti mesto stalnim zubima.", null },
                    { 2021, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 2, 2002, "Kako da naučite dijete šta je pravilna higijena zuba?", "Higijena zuba kod dece je tema koja roditelje često brine. Kada početi sa pranjem zuba i da li je važno detaljno pranje mlečnih zuba su dva pitanja koja najčešće čujemo. Zube kod beba je potrebno početi prati čim izrastu. U početku je najbolje da se higijena zuba održava parčetom gaze, koju ćete namotati oko svog kažiprsta i nežno preći preko svih zuba i desni bebe. Uz to koristite ili mlaku vodu ili čaj od kamilice. Ovaj način pranja zuba kod beba primenjujte obavezno pred spavanje, ali po potrebi i u toku dana. Deci do 3 godine stavite na četkicu količinu paste veličine zrna pirinča, a deci od 3 do 6 godina veličine zrna graška.  Koliko često treba prati zube detetu? Higijena zuba treba da se održava redovno. Dete bi trebalo da naučite da zube mora da pere ujutro i uveče, po 2 minuta. Ovo ćete najlakše uraditit tako što ćete detetu puštati njegovu omiljenu pesmu ili video u trajanju od 2 minuta i na taj način će dete znati koliko vremenski treba da traje pranje zuba.", null },
                    { 2011, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1002, 2002, "Veštački zubi - vrste, procedura ugradnje, cena i održavanje", "Potrebe za nadograđivanjem zuba su poprilično raznoliki. Gubitak istih se može desiti zbog nemarnog odnosa prema higijeni, zbog spoljnog faktora, udarca, paradentoze i zbog mnogih drugih oboljenja.  Specifičnost zubnih proteza je u tome što mogu da se uklanjaju iz usta, zbog čega se i zovu mobilne nadoknade izgubljenih zuba. Proteze pacijent ih sam stavlja i skida radi održavanja higijene. Totalna zubna proteza je namenjena osobama koje nemaju nijedan zub u vilici. Totalna proteza nadoknađuje sve zube koji nedostaju, ali i deo alveolarnog grebena. Međutim, ono što sigurno jeste zajednička vrednost jeste da zubima, bili veštački ili prirodni, treba pristupati odgovorno i uz visoka higijenska načela. Održavanje podrazumeva redovno pranje, ispiranje, održavanje desni.  Korišćenje alkohola, cigareta ali i napitaka punih šećera mogu napraviti problem zubima, bilo da su prirodni ili veštački. Gomilanje bakterija u usnoj duplji je protivnik zdravlju. Treba koristiti četkice koje pristupaju svim delovima zuba.   ", null },
                    { 2014, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1002, 2002, "Nadogradnja zuba na koren i kada se primenjuje", "Razlozi zbog koga mnogi ljudi mogu ostati bez zuba može biti apsolutno raznolik. Naime, od fizičkih povreda, sportskih povreda, povreda izazvanih udarcima, pa do gubitka dela zuba zbog karijesa ili neke druge bolesti, varira paleta mogućnosti da se ostane bez celog ili dela zuba. Kada se nešto desi, postoji nebrojeno mogućnosti da se zub spasi.  Može se reći da je nadogradnja zuba poželjna onda kada zub nije moguće nadograditi plombom, a kada nije potrebno pristuptiti nekoj težoj i komplikovanijoj metodi. Naravno da ne treba da krivite sebe onda kada se stvar već zakomplikuje. Nakon što nađete načina da nadogradite zub, bilo da ste se odlučili za fiberglas, metalno livenje ili bilo koju drugu nadogradnju, nakon toga morate ispoštovati određene rituale. Štitite se tokom bavljenja sportom. Izbegavajte slatkiše. Iako je u pitanju zub koji više nije prirodan, okolno tkivo je živo. Šećeri koje unosite slatkišima pretvaraju se u štetne bakterije i kiseline koje razaraju tkivo desni, ali i okolnih zuba. Budite obazrivi i odmereni kada unosite slatkiše.  ", null },
                    { 2006, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1003, 2002, "Plombiranje zuba - kada se i zašto primenjuje?", "Pokvaren zub je zub zahvaćenen karijesom. To je progresivno oboljenje zuba koje se može zaustaviti i lečiti, a jedini način je njegovo kompletno uklanjanje. Najjednostavnije rečeno, karijes je ništa drugo do rupa u zubu.  Nakon otvaranja zuba i uklanjanja karijesa posebnim stomatološkim instrumentima, u zavisnosti od toga koliki kvar je bio u pitanju, odnosno koliko duboko je karijes zahvatio zubna tkiva, stomatolog može uraditi privremeno ili definitivno punjenje zuba. U zavisnosti od prirode i veličine kvara, kao i toka lečenja zuba, zubar može odlučiti koje će materijale koristiti za definitivno punjenje. Premda se do skoro verovalo da nema jačih i trajnijih plombi od amalgamskih, razvoj stomatološke nauke i tehnologije materijala doveo je na prvo mesto kompozitne, odnosno bele plombe.  U prilog belim plombama ide i estetski faktor – jednom postavljene, one su gotovo neprimetne golim okom. Ovo je posebno značajno kada se saniraju kvarovi na prednjim zubima.", null },
                    { 2007, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1003, 2002, "Povlačenje desni - uzroci, simptomi, prevencija i lečenje", "Povučene desni postaju pravi zdravstveni problem onog trenutka kada su koreni zuba izloženi, te je povećan rizik od infekcija, propadanja i gubitka zuba.  Lečenje koje se započne u ranoj fazi povlačenja desni može zaustaviti ili čak preokrenuti proces recesije gingive. Lek za povlačenje desni odrediće stepen povlačenja – ako se pored atrofije jave i drugi simptomi kao što su osetljivost zuba, bol ili infekcija, tada će i lečenje biti ozbiljnije. Ljudi sa osetljivijim tkivom su su skloniji upalama. Isto važi i za osobe sa tanjom gingivom, jer su veće šanse da će kod njih  dentalni plak izazvati infekciju. Na prvom mestu tu je  gingivitis ili zapaljenje desni, koje se može razviti u ozbiljnije upalne procese i bolesti poput paradontopatije. Najbolje je da zube perete dva puta dnevno u trajanju od dva minuta, pod uglom od 45 stepeni. Ukoliko ste zabrinuti za svoje zube ili primećujete prve znake ove bolseti dođite u našu  stomatološku ordinaciju kako bismo porazgovarali o ovom problemu i zajednički došli do rešenja.", null },
                    { 2024, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1006, 2002, "Ortodoncija", "Ortodontska terapija nije važna samo zbog lijepog osmijeha, nego i radi dobrobiti cijelog stomatognatog sistema. Nepravilni zagriz utječe na čeljusni zglob i dolazi do neravnomjernog trošenja zubi i neravnomjerne raspodjele sila na zube, što ujedno štetno djeluje na zubno meso. Zbijeni zubi otežavaju čišćenje te pogoduju nastanku karijesa i parodontne bolesti.  Na prvom posjetu kod specijalista ortodoncije napravi se detaljan pregled i analiza te se uzme otisak za studijske modele. Uz analizu modela, ortopantomograma i telerendgentske analize, specijalist ortodoncije može postaviti tačnu dijagnozu i napraviti plan terapije.  U većini slučaja retencija je napravljena od prozirne plastike, tako da estetski zadovoljava. Iznimno je važno nositi retenciju po uputama ortodonta kako bi se spriječili nepoželjni pomaci zuba.  Naravno, oralna higijena je prijeko potrebna za uspjeh ortodontskog liječenja. Profesionalno ćišćenje prije, tijekom i nakon skidanja ortodontskog aparta potrebno je kako bi se održala odlična oralna higijena i osigurala uspješna ortodontska terapija.", null },
                    { 2037, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1007, 2002, "Oralnokirurški zahvati ", "Najčešći oralnokirurški zahvati povezani sa zubima i ustima su:  vađenje zuba i zubnih korijenova (ekstrakcija) alveotomija zuba (operacijsko vađenje, vađenje umnjaka) apikotomija (apicektomija) zuba-micanje vrška korijena zbog upale frenulektomija cistektomija kortikotomija VAĐENJE ZUBA  Vađenje zuba je kirurški zahvat tijekom kojeg oralni kirurg pomoću kliješta i drugih instrumenata uklanja iz usta zub koji je iz nekog razloga (upala, pucanje/trauma, prekobrojni zubi i dr.) potrebno izvaditi. ALVEOTOMIJA ZUBA  Alveotomija je kirurški zahvat tijekom kojeg se uklanja zub koji se djelomično ili potpuno nalazi u kosti i/ili ispod zubnog mesa (impaktirani i retinirani zubi, prekobrojni zubi i dr.), zbog čega je potrebno „otvoriti“ zubno meso i djelomično izbrusiti kost da bi se takav zub mogao izvaditi. FRENULEKTOMIJA  Frenulektomija je kirurški zahvat kojim se uklanja ili premješta mali nabor sluznice ispod gornje usne – frenulum kako bi se omogućilo pravilno postavljanje i spajanje gornjih prednjih zubi. Obično se provodi u sklopu ortodontske terapije.  CISTEKTOMIJA  Cistektomija je kirurški zahvat kojim se uklanjaju šuplje tvorbe u kosti čeljusti koje zovemo ciste. One mogu nastati iz raznih razloga (upala, trauma, razvojne nepravilnosti i dr.), a potrebno ih je ukloniti jer svojim rastom razaraju kost i mogu ugroziti zdravlje zubi.  KORTIKOTOMIJA  Kortikotomija predstavlja operativni zahvat koji se provodi na zubima koji postoje negdje u kosti gornje ili donje čeljusti, ali nisu nikli i ne vide se u zubnom nizu. ", null },
                    { 2036, new DateTime(2020, 12, 4, 23, 24, 40, 0, DateTimeKind.Unspecified), 1007, 2002, "Prvi pregled ", "Prvi pregled čine:  anamneza – povijest bolesti, na prvom pregledu specijalist oralne kirurgije će kroz razgovor dobiti od pacijenta bitne informacije o njegovom zdravstvenom stanju klinički pregled u ustima-pregledom u ustima oralni će kirurg detaljno procijenti pacijentovo oralno zdravlje analiza različitih rtg snimaka- najčešće je to ortopan i intraoralni rtg, a u zadnje vrijeme i CBCT (CT čeljusti) uz pomoć kojih će specijalist oralne kirurgije postaviti ispravnu dijagnozu i odrediti je li i kada potrebno pristupiti oralnokirurškom zahvatu. Na prvom pregledu specijalist oralne kirurgije će kroz razgovor dobiti od pacijenta bitne informacije o njegovom zdravstvenom stanju, bolestima od kojih je prethodno bolovao ili još uvijek boluje, lijekovima koje uzima povremeno ili stalno, eventualnim fizičkim traumama (prometna nesreća, pad, udarac) i slično. Analiza rtg snimaka postupak je tijekom kojeg oralni kirurg pregledom različitih vrsta rtg snimaka, od kojih su najčešći:  ortopantomogram, intraoralni ciljani rtg snimak, CBCT snimak; Na taj način kirurg dobiva informacije koje nisu dostupne kliničkim pregledom (npr. postojanje upalnog procesa u kosti, lokalizacija neizraslog zuba, veličina i položaj ciste, debljina i širina kosti pri planiranju implantološke terapije i drugo).", null }
                });

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "GradId", "DrzavaId", "Naziv", "PostanskiBroj" },
                values: new object[] { 1, 1, "Mostar", "88000" });

            migrationBuilder.InsertData(
                table: "KorisnikUloga",
                columns: new[] { "KorisnikUlogaId", "DatumIzmjene", "KorisnikId", "UlogaId" },
                values: new object[] { 1002, new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2002, 1 });

            migrationBuilder.InsertData(
                table: "MedicinskiKarton",
                columns: new[] { "MedicinskiKartonId", "DatumVrijeme", "Naziv", "Opis", "PacijentId" },
                values: new object[,]
                {
                    { 1025, new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medicinski karton -> test Pacijent", null, 2012 },
                    { 1022, new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medicinski karton -> Azra Opijac", "/", 2009 }
                });

            migrationBuilder.InsertData(
                table: "Rezervacija",
                columns: new[] { "RezervacijaId", "Aktivna", "DatumVrijeme", "PacijentId", "Razlog", "UslugaId" },
                values: new object[,]
                {
                    { 2018, false, new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2009, "jaka bol zuba", 2 },
                    { 2028, true, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2012, "izbjeljivanje zuba - testPacijent", 2006 },
                    { 2026, true, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2009, "konsultacije sa doktorom", 2008 },
                    { 2024, false, new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2012, "potreban novi snimak zuba", 2009 }
                });

            migrationBuilder.InsertData(
                table: "Adresa",
                columns: new[] { "AdresaId", "GradId", "Naziv" },
                values: new object[] { 1, 1, "Bulevar 15" });

            migrationBuilder.InsertData(
                table: "Ocjena",
                columns: new[] { "OcjenaId", "ClanakId", "ocjena", "PacijentId" },
                values: new object[,]
                {
                    { 2, 2011, 9m, 2012 },
                    { 4, 2011, 10m, 2009 },
                    { 3, 2006, 7m, 2012 },
                    { 5, 2006, 0m, 2009 },
                    { 6, 2037, 10m, 2009 }
                });

            migrationBuilder.InsertData(
                table: "Pregled",
                columns: new[] { "PregledId", "DatumVrijeme", "DijagnozaId", "KorisnikId", "LijekId", "MedicinskiKartonId", "Naziv", "Opis", "RezervacijaId" },
                values: new object[,]
                {
                    { 1023, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2002, 1, 1022, "Azra - popravak", "bez opisa", 2018 },
                    { 1030, new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1009, 2002, 1, 1025, "testPacijent - snimak", "snimak gornje vilice", 2024 }
                });

            migrationBuilder.InsertData(
                table: "StomatoloskaOrdinacija",
                columns: new[] { "StomatoloskaOrdinacijaId", "AdresaId", "BrojTelefona", "Email", "Naziv", "RadnoVrijemeDo", "RadnoVrijemeOd" },
                values: new object[] { 1, 1, "+3876254999", "mydentalcare@info.com", "My Dental Care", new DateTime(2020, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Adresa_GradId",
                table: "Adresa",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "GradId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clanak_KategorijaId",
                table: "Clanak",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clanak_KorisnikId",
                table: "Clanak",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId",
                principalTable: "Drzava",
                principalColumn: "DrzavaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloga_UlogaId",
                table: "KorisnikUloga",
                column: "UlogaId",
                principalTable: "Uloga",
                principalColumn: "UlogaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicinskiKarton_PacijentId",
                table: "MedicinskiKarton",
                column: "PacijentId",
                principalTable: "Pacijent",
                principalColumn: "PacijentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjena_ClanakId",
                table: "Ocjena",
                column: "ClanakId",
                principalTable: "Clanak",
                principalColumn: "ClanakId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjena_PacijentId",
                table: "Ocjena",
                column: "PacijentId",
                principalTable: "Pacijent",
                principalColumn: "PacijentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_DijagnozaId",
                table: "Pregled",
                column: "DijagnozaId",
                principalTable: "Dijagnoza",
                principalColumn: "DijagnozaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_KorisnikId",
                table: "Pregled",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_LijekId",
                table: "Pregled",
                column: "LijekId",
                principalTable: "Lijek",
                principalColumn: "LijekId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_MedicinskiKartonId",
                table: "Pregled",
                column: "MedicinskiKartonId",
                principalTable: "MedicinskiKarton",
                principalColumn: "MedicinskiKartonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_RezervacijaId",
                table: "Pregled",
                column: "RezervacijaId",
                principalTable: "Rezervacija",
                principalColumn: "RezervacijaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_PacijentId",
                table: "Rezervacija",
                column: "PacijentId",
                principalTable: "Pacijent",
                principalColumn: "PacijentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_UslugaId",
                table: "Rezervacija",
                column: "UslugaId",
                principalTable: "Usluga",
                principalColumn: "UslugaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StomatoloskaOrdinacija_AdresaId",
                table: "StomatoloskaOrdinacija",
                column: "AdresaId",
                principalTable: "Adresa",
                principalColumn: "AdresaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresa_GradId",
                table: "Adresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Clanak_KategorijaId",
                table: "Clanak");

            migrationBuilder.DropForeignKey(
                name: "FK_Clanak_KorisnikId",
                table: "Clanak");

            migrationBuilder.DropForeignKey(
                name: "FK_Grad_DrzavaId",
                table: "Grad");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloga_UlogaId",
                table: "KorisnikUloga");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicinskiKarton_PacijentId",
                table: "MedicinskiKarton");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjena_ClanakId",
                table: "Ocjena");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjena_PacijentId",
                table: "Ocjena");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_DijagnozaId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_KorisnikId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_LijekId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_MedicinskiKartonId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Pregled_RezervacijaId",
                table: "Pregled");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_PacijentId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_UslugaId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_StomatoloskaOrdinacija_AdresaId",
                table: "StomatoloskaOrdinacija");

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Dijagnoza",
                keyColumn: "DijagnozaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dijagnoza",
                keyColumn: "DijagnozaId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Lijek",
                keyColumn: "LijekId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Lijek",
                keyColumn: "LijekId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ocjena",
                keyColumn: "OcjenaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pregled",
                keyColumn: "PregledId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Pregled",
                keyColumn: "PregledId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "StomatoloskaOrdinacija",
                keyColumn: "StomatoloskaOrdinacijaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usluga",
                keyColumn: "UslugaId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Adresa",
                keyColumn: "AdresaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Clanak",
                keyColumn: "ClanakId",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Dijagnoza",
                keyColumn: "DijagnozaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dijagnoza",
                keyColumn: "DijagnozaId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Lijek",
                keyColumn: "LijekId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicinskiKarton",
                keyColumn: "MedicinskiKartonId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "MedicinskiKarton",
                keyColumn: "MedicinskiKartonId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usluga",
                keyColumn: "UslugaId",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Usluga",
                keyColumn: "UslugaId",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Kategorija",
                keyColumn: "KategorijaId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Usluga",
                keyColumn: "UslugaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usluga",
                keyColumn: "UslugaId",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaId",
                keyValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresa_GradId",
                table: "Adresa",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "GradId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clanak_KategorijaId",
                table: "Clanak",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "KategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clanak_KorisnikId",
                table: "Clanak",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId",
                principalTable: "Drzava",
                principalColumn: "DrzavaId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloga_UlogaId",
                table: "KorisnikUloga",
                column: "UlogaId",
                principalTable: "Uloga",
                principalColumn: "UlogaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicinskiKarton_PacijentId",
                table: "MedicinskiKarton",
                column: "PacijentId",
                principalTable: "Pacijent",
                principalColumn: "PacijentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjena_ClanakId",
                table: "Ocjena",
                column: "ClanakId",
                principalTable: "Clanak",
                principalColumn: "ClanakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjena_PacijentId",
                table: "Ocjena",
                column: "PacijentId",
                principalTable: "Pacijent",
                principalColumn: "PacijentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_DijagnozaId",
                table: "Pregled",
                column: "DijagnozaId",
                principalTable: "Dijagnoza",
                principalColumn: "DijagnozaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_KorisnikId",
                table: "Pregled",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_LijekId",
                table: "Pregled",
                column: "LijekId",
                principalTable: "Lijek",
                principalColumn: "LijekId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_MedicinskiKartonId",
                table: "Pregled",
                column: "MedicinskiKartonId",
                principalTable: "MedicinskiKarton",
                principalColumn: "MedicinskiKartonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pregled_RezervacijaId",
                table: "Pregled",
                column: "RezervacijaId",
                principalTable: "Rezervacija",
                principalColumn: "RezervacijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_PacijentId",
                table: "Rezervacija",
                column: "PacijentId",
                principalTable: "Pacijent",
                principalColumn: "PacijentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_UslugaId",
                table: "Rezervacija",
                column: "UslugaId",
                principalTable: "Usluga",
                principalColumn: "UslugaId");

            migrationBuilder.AddForeignKey(
                name: "FK_StomatoloskaOrdinacija_AdresaId",
                table: "StomatoloskaOrdinacija",
                column: "AdresaId",
                principalTable: "Adresa",
                principalColumn: "AdresaId");
        }
    }
}
