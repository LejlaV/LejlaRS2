using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyDentalCare.WebAPI.Database
{
	public partial class MyDentalCareContext
	{
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Uloga>().HasData(new WebAPI.Database.Uloga()
			{
					UlogaId = 1,
					Naziv = "administrator"
			});
			modelBuilder.Entity<Korisnik>().HasData(new WebAPI.Database.Korisnik()
			{
				KorisnikId = 2002,
				Ime = "Lejla",
				Prezime = "Vejzovic",
				DatumRodjenja = new DateTime(1998, 3, 28),
				Email = "lejla.vejzovic@edufit.ba",
				BrojTelefona = "38762598895",
				KorisnickoIme = "lejlav",
				PasswordHash = "rVJJ78RFz9/58/wfAx5L7lka+0w=",
				PasswordSalt = "2qm2bCZGHu5ani8g10pmQA=="
			});
			modelBuilder.Entity<KorisnikUloga>().HasData(new WebAPI.Database.KorisnikUloga()
			{
				KorisnikId = 2002,
				UlogaId = 1,
				KorisnikUlogaId = 1002,
				DatumIzmjene = new DateTime(2020, 12, 3)
			});
			
			modelBuilder.Entity<Usluga>().HasData(new WebAPI.Database.Usluga()
			{
				UslugaId = 2,
				Naziv = "popravak zuba",
				Cijena = 30
			});
			modelBuilder.Entity<Usluga>().HasData(new WebAPI.Database.Usluga()
			{
				UslugaId = 1002,
				Naziv = "stavljanje plombe",
				Cijena = 35
			});
			modelBuilder.Entity<Usluga>().HasData(new WebAPI.Database.Usluga()
			{
				UslugaId = 2006,
				Naziv = "ordinacijsko beljenje laserom",
				Cijena = 250
			});
			modelBuilder.Entity<Usluga>().HasData(new WebAPI.Database.Usluga()
			{
				UslugaId = 2008,
				Naziv = "pregled specijaliste",
				Cijena = 30
			});
			modelBuilder.Entity<Usluga>().HasData(new WebAPI.Database.Usluga()
			{
				UslugaId = 2009,
				Naziv = "RTG Snimak",
				Cijena = 15
			});
			modelBuilder.Entity<Dijagnoza>().HasData(new WebAPI.Database.Dijagnoza()
			{
				DijagnozaId = 1,
				Naziv = "paradentoza"
			});
			modelBuilder.Entity<Dijagnoza>().HasData(new WebAPI.Database.Dijagnoza()
			{
				DijagnozaId = 2,
				Naziv = "karijes"
			});
			modelBuilder.Entity<Dijagnoza>().HasData(new WebAPI.Database.Dijagnoza()
			{
				DijagnozaId = 1009,
				Naziv = "snimanje"
			});
			modelBuilder.Entity<Dijagnoza>().HasData(new WebAPI.Database.Dijagnoza()
			{
				DijagnozaId = 1010,
				Naziv = "izbjeljivanje"
			});
			modelBuilder.Entity<Lijek>().HasData(new WebAPI.Database.Lijek()
			{
				LijekId = 1,
				Naziv = "paracetamol",
				Uputstvo = "Koriste se za ublažavanje blage do umjerene boli i snižavanje povišene tjelesne temperature. Lijek je namijenjen za kratkotrajnu primjenu u odraslih i djece starije od 6 godina (tjelesne težine iznad 21 kg)."
			});

			modelBuilder.Entity<Lijek>().HasData(new WebAPI.Database.Lijek()
			{
				LijekId = 1002,
				Naziv = "Afobazol",
				Uputstvo = "Preporučuje se uporaba lijeka tri puta dnevno, 10 mg (1 tableta). Ako pacijent doživi jake negativne osjećaje, dopušteno je da se ova doza udvostruči. Lijek treba nastaviti najmanje 7 dana. Prosječni tijek liječenja je 2-4 sedmice."
			});
			modelBuilder.Entity<Lijek>().HasData(new WebAPI.Database.Lijek()
			{
				LijekId = 1003,
				Naziv = "Glicin",
				Uputstvo = "Prema uputama, ovaj lijek je potrebno uzimati 1 tabletu 2 ili 3 puta dnevno. U isto vrijeme potrebno ju je otopiti ili slomiti. Trajanje terapije je 2-4 tjedna. Za bebe do 3 godine, doza se smanjuje 2 puta."
			});
			modelBuilder.Entity<Kategorija>().HasData(new WebAPI.Database.Kategorija()
			{
				KategorijaId = 1,
				Naziv = "Opća stomatologija"
			});
			modelBuilder.Entity<Kategorija>().HasData(new WebAPI.Database.Kategorija()
			{
				KategorijaId = 2,
				Naziv = "Porodična stomatologija"
			});
			modelBuilder.Entity<Kategorija>().HasData(new WebAPI.Database.Kategorija()
			{
				KategorijaId = 1002,
				Naziv = "Estetska stomatologija"
			});
			modelBuilder.Entity<Kategorija>().HasData(new WebAPI.Database.Kategorija()
			{
				KategorijaId = 1003,
				Naziv = "Parodontologija"
			});
			modelBuilder.Entity<Kategorija>().HasData(new WebAPI.Database.Kategorija()
			{
				KategorijaId = 1006,
				Naziv = "Ortodoncija"
			});
			modelBuilder.Entity<Kategorija>().HasData(new WebAPI.Database.Kategorija()
			{
				KategorijaId = 1007,
				Naziv = "Oralna hirurgija"
			});
			modelBuilder.Entity<Pacijent>().HasData(new WebAPI.Database.Pacijent()
			{
				PacijentId = 2012,
				Ime = "test",
				Prezime = "Pacijent",
				KorisnickoIme = "testPacijent",
				Email = "testPacijent@outlook.com",
				BrojTelefona = "635823336",
				PasswordHash = "YMjPSdqRMWfDshfWOZOotTf032E=",
				PasswordSalt = "ytubYZVEbxq2c7u9sozriA=="
			});

			modelBuilder.Entity<Pacijent>().HasData(new WebAPI.Database.Pacijent()
			{
				PacijentId = 2009,
				Ime = "Azra",
				Prezime = "Opijac",
				KorisnickoIme = "AzraO",
				Email = "azraopijac@hotmail.com",
				BrojTelefona = "625897431",
				PasswordHash = "ArIYMMigRHZw/YT30VDzvcTV1cQ=",
				PasswordSalt = "X4s1DH5UTTtGdMokWQvnKQ=="
			});
			modelBuilder.Entity<Rezervacija>().HasData(new WebAPI.Database.Rezervacija()
			{
				RezervacijaId = 2018,
				DatumVrijeme = new DateTime(2020, 9, 20),
				Razlog = "jaka bol zuba",
				Aktivna = false,
				PacijentId = 2009,
				UslugaId = 2
			});
			modelBuilder.Entity<Rezervacija>().HasData(new WebAPI.Database.Rezervacija()
			{
				RezervacijaId = 2026,
				DatumVrijeme = new DateTime(2021, 1, 27),
				Razlog = "konsultacije sa doktorom",
				Aktivna = true,
				PacijentId = 2009,
				UslugaId = 2008
			});
			modelBuilder.Entity<Rezervacija>().HasData(new WebAPI.Database.Rezervacija()
			{
				RezervacijaId = 2024,
				DatumVrijeme = new DateTime(2020, 4, 24),
				Razlog = "potreban novi snimak zuba",
				Aktivna = false,
				PacijentId = 2012,
				UslugaId = 2009
			});
			modelBuilder.Entity<Rezervacija>().HasData(new WebAPI.Database.Rezervacija()
			{
				RezervacijaId = 2028,
				DatumVrijeme = new DateTime(2021, 1, 31),
				Razlog = "izbjeljivanje zuba - testPacijent",
				Aktivna = true,
				PacijentId = 2012,
				UslugaId = 2006
			});
			modelBuilder.Entity<MedicinskiKarton>().HasData(new WebAPI.Database.MedicinskiKarton()
			{
				MedicinskiKartonId = 1025,
				Naziv = "Medicinski karton -> test Pacijent",
				PacijentId = 2012,
				DatumVrijeme = new DateTime(2020, 3, 22)
			});
			modelBuilder.Entity<MedicinskiKarton>().HasData(new WebAPI.Database.MedicinskiKarton()
			{
				MedicinskiKartonId = 1022,
				Naziv = "Medicinski karton -> Azra Opijac",
				Opis = "/",
				PacijentId = 2009,
				DatumVrijeme = new DateTime(2020, 12, 20)
			});
			modelBuilder.Entity<Pregled>().HasData(new WebAPI.Database.Pregled()
			{
				PregledId = 1023,
				MedicinskiKartonId = 1022,
				DatumVrijeme = new DateTime(2020, 9, 21),
				Naziv = "Azra - popravak",
				Opis = "bez opisa",
				DijagnozaId = 2,
				LijekId = 1,
				KorisnikId = 2002,
				RezervacijaId = 2018
			});
			modelBuilder.Entity<Pregled>().HasData(new WebAPI.Database.Pregled()
			{
				PregledId = 1030,
				MedicinskiKartonId = 1025,
				DatumVrijeme = new DateTime(2020, 4, 24),
				Naziv = "testPacijent - snimak",
				Opis = "snimak gornje vilice",
				DijagnozaId = 1009,
				LijekId = 1,
				KorisnikId = 2002,
				RezervacijaId = 2024
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2008,
				KategorijaId = 1,
				Naslov = "Električne četkice za zube – dobar ili loš izbor?",
				Sadrzaj = "Električna četkica za zube je zapravo četkica za zube koja pravi automatske pokrete i oscilacije, a izuzetno pomaže boljem čišćenju zubne površine. Ovi pokreti su posledica elektromotora koji se može pokretati pomoću baterija. Različite frekvencije oscilacija i brzina zavise od toga kakvog je kapaciteta električna četkica za zube. Kome god je padalo na pamet da običnu četkicu za zube zameni električnom, savetujemo da to i uradi i testira da li mu odgovara.",
				DatumObjave = new DateTime(2020, 12, 3, 20, 34, 40),
				KorisnikId = 2002
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2012,
				KategorijaId = 2,
				KorisnikId = 2002,
				Naslov = "Mlečni zubi i sve što treba znati o njima",
				Sadrzaj = "Ovaj blog posvećen je mnogim odgovorima na pitanja koja se tiču zuba, rasta zuba kod deteta, menjanja zuba kod deteta, ali i kvarova na mlečnim zubima. Nicanje zuba Ovaj proces muči mnoge koji zube shvataju podrazumevanom vrednošću, a kao i većina ne pamte vreme kada su im nicali prvi zubiDa se ne bi oštetile desni, poželjno je da ugao između zuba i desni i četkice bude 45 stepeni. Kružnim pokretima čisteći zub po zub, a potom i četkanjem cele površine, četkaju se svi zubi. Samo je potrebno odreagovati na vreme. Međutim, ukoliko dođe do kvarenja ostalih zuba i širenja karijesa, to može napraviti infekciju, koja rezultira vađenjem zuba i lošim formiranjem vilične kosti. Zbog toga što se naredni zub koji treba da nikne povlači na mesto onog koji fali, potrebno je ugraditi distancer. Ukoliko se to ne uradi, susedni zubi mogu zauzeti mesto stalnim zubima.",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2021,
				KategorijaId = 2,
				KorisnikId = 2002,
				Naslov = "Kako da naučite dijete šta je pravilna higijena zuba?",
				Sadrzaj = "Higijena zuba kod dece je tema koja roditelje često brine. Kada početi sa pranjem zuba i da li je važno detaljno pranje mlečnih zuba su dva pitanja koja najčešće čujemo. Zube kod beba je potrebno početi prati čim izrastu. U početku je najbolje da se higijena zuba održava parčetom gaze, koju ćete namotati oko svog kažiprsta i nežno preći preko svih zuba i desni bebe. Uz to koristite ili mlaku vodu ili čaj od kamilice. Ovaj način pranja zuba kod beba primenjujte obavezno pred spavanje, ali po potrebi i u toku dana. Deci do 3 godine stavite na četkicu količinu paste veličine zrna pirinča, a deci od 3 do 6 godina veličine zrna graška.  Koliko često treba prati zube detetu? Higijena zuba treba da se održava redovno. Dete bi trebalo da naučite da zube mora da pere ujutro i uveče, po 2 minuta. Ovo ćete najlakše uraditit tako što ćete detetu puštati njegovu omiljenu pesmu ili video u trajanju od 2 minuta i na taj način će dete znati koliko vremenski treba da traje pranje zuba.",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2011,
				KategorijaId = 1002,
				KorisnikId = 2002,
				Naslov = "Veštački zubi - vrste, procedura ugradnje, cena i održavanje",
				Sadrzaj = "Potrebe za nadograđivanjem zuba su poprilično raznoliki. Gubitak istih se može desiti zbog nemarnog odnosa prema higijeni, zbog spoljnog faktora, udarca, paradentoze i zbog mnogih drugih oboljenja.  Specifičnost zubnih proteza je u tome što mogu da se uklanjaju iz usta, zbog čega se i zovu mobilne nadoknade izgubljenih zuba. Proteze pacijent ih sam stavlja i skida radi održavanja higijene. Totalna zubna proteza je namenjena osobama koje nemaju nijedan zub u vilici. Totalna proteza nadoknađuje sve zube koji nedostaju, ali i deo alveolarnog grebena. Međutim, ono što sigurno jeste zajednička vrednost jeste da zubima, bili veštački ili prirodni, treba pristupati odgovorno i uz visoka higijenska načela. Održavanje podrazumeva redovno pranje, ispiranje, održavanje desni.  Korišćenje alkohola, cigareta ali i napitaka punih šećera mogu napraviti problem zubima, bilo da su prirodni ili veštački. Gomilanje bakterija u usnoj duplji je protivnik zdravlju. Treba koristiti četkice koje pristupaju svim delovima zuba.   ",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2014,
				KategorijaId = 1002,
				KorisnikId = 2002,
				Naslov = "Nadogradnja zuba na koren i kada se primenjuje",
				Sadrzaj = "Razlozi zbog koga mnogi ljudi mogu ostati bez zuba može biti apsolutno raznolik. Naime, od fizičkih povreda, sportskih povreda, povreda izazvanih udarcima, pa do gubitka dela zuba zbog karijesa ili neke druge bolesti, varira paleta mogućnosti da se ostane bez celog ili dela zuba. Kada se nešto desi, postoji nebrojeno mogućnosti da se zub spasi.  Može se reći da je nadogradnja zuba poželjna onda kada zub nije moguće nadograditi plombom, a kada nije potrebno pristuptiti nekoj težoj i komplikovanijoj metodi. Naravno da ne treba da krivite sebe onda kada se stvar već zakomplikuje. Nakon što nađete načina da nadogradite zub, bilo da ste se odlučili za fiberglas, metalno livenje ili bilo koju drugu nadogradnju, nakon toga morate ispoštovati određene rituale. Štitite se tokom bavljenja sportom. Izbegavajte slatkiše. Iako je u pitanju zub koji više nije prirodan, okolno tkivo je živo. Šećeri koje unosite slatkišima pretvaraju se u štetne bakterije i kiseline koje razaraju tkivo desni, ali i okolnih zuba. Budite obazrivi i odmereni kada unosite slatkiše.  ",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2006,
				KategorijaId = 1003,
				KorisnikId = 2002,
				Naslov = "Plombiranje zuba - kada se i zašto primenjuje?",
				Sadrzaj = "Pokvaren zub je zub zahvaćenen karijesom. To je progresivno oboljenje zuba koje se može zaustaviti i lečiti, a jedini način je njegovo kompletno uklanjanje. Najjednostavnije rečeno, karijes je ništa drugo do rupa u zubu.  Nakon otvaranja zuba i uklanjanja karijesa posebnim stomatološkim instrumentima, u zavisnosti od toga koliki kvar je bio u pitanju, odnosno koliko duboko je karijes zahvatio zubna tkiva, stomatolog može uraditi privremeno ili definitivno punjenje zuba. U zavisnosti od prirode i veličine kvara, kao i toka lečenja zuba, zubar može odlučiti koje će materijale koristiti za definitivno punjenje. Premda se do skoro verovalo da nema jačih i trajnijih plombi od amalgamskih, razvoj stomatološke nauke i tehnologije materijala doveo je na prvo mesto kompozitne, odnosno bele plombe.  U prilog belim plombama ide i estetski faktor – jednom postavljene, one su gotovo neprimetne golim okom. Ovo je posebno značajno kada se saniraju kvarovi na prednjim zubima.",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2007,
				KategorijaId = 1003,
				KorisnikId = 2002,
				Naslov = "Povlačenje desni - uzroci, simptomi, prevencija i lečenje",
				Sadrzaj = "Povučene desni postaju pravi zdravstveni problem onog trenutka kada su koreni zuba izloženi, te je povećan rizik od infekcija, propadanja i gubitka zuba.  Lečenje koje se započne u ranoj fazi povlačenja desni može zaustaviti ili čak preokrenuti proces recesije gingive. Lek za povlačenje desni odrediće stepen povlačenja – ako se pored atrofije jave i drugi simptomi kao što su osetljivost zuba, bol ili infekcija, tada će i lečenje biti ozbiljnije. Ljudi sa osetljivijim tkivom su su skloniji upalama. Isto važi i za osobe sa tanjom gingivom, jer su veće šanse da će kod njih  dentalni plak izazvati infekciju. Na prvom mestu tu je  gingivitis ili zapaljenje desni, koje se može razviti u ozbiljnije upalne procese i bolesti poput paradontopatije. Najbolje je da zube perete dva puta dnevno u trajanju od dva minuta, pod uglom od 45 stepeni. Ukoliko ste zabrinuti za svoje zube ili primećujete prve znake ove bolseti dođite u našu  stomatološku ordinaciju kako bismo porazgovarali o ovom problemu i zajednički došli do rešenja.",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2024,
				KategorijaId = 1006,
				KorisnikId = 2002,
				Naslov = "Ortodoncija",
				Sadrzaj = "Ortodontska terapija nije važna samo zbog lijepog osmijeha, nego i radi dobrobiti cijelog stomatognatog sistema. Nepravilni zagriz utječe na čeljusni zglob i dolazi do neravnomjernog trošenja zubi i neravnomjerne raspodjele sila na zube, što ujedno štetno djeluje na zubno meso. Zbijeni zubi otežavaju čišćenje te pogoduju nastanku karijesa i parodontne bolesti.  Na prvom posjetu kod specijalista ortodoncije napravi se detaljan pregled i analiza te se uzme otisak za studijske modele. Uz analizu modela, ortopantomograma i telerendgentske analize, specijalist ortodoncije može postaviti tačnu dijagnozu i napraviti plan terapije.  U većini slučaja retencija je napravljena od prozirne plastike, tako da estetski zadovoljava. Iznimno je važno nositi retenciju po uputama ortodonta kako bi se spriječili nepoželjni pomaci zuba.  Naravno, oralna higijena je prijeko potrebna za uspjeh ortodontskog liječenja. Profesionalno ćišćenje prije, tijekom i nakon skidanja ortodontskog aparta potrebno je kako bi se održala odlična oralna higijena i osigurala uspješna ortodontska terapija.",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2025,
				KategorijaId = 1006,
				KorisnikId = 2002,
				Naslov = "Folije za ispravljanje zuba",
				Sadrzaj = "Folije za ispravljanje zuba (alajneri) čine set providnih folija za zube kojima na komforan način možete rešiti nepravilan položaj zuba. Pacijenti ih danas vrlo rado biraju zbog mogućnosti da isprave anomalije svojih zuba, a da sam proces ne bude vidljiv. Ponekad ih nazivaju i nevidljivom fiksnom protezom.  Šta su to folije za ispravljanje zuba? Ove folije služe da blagom silom deluju na zube i na taj način ih pomeraju. Napravljene su od tanke, providne plastike, glatke na dodir i udobne za nošenje.Kome je namenjen ovaj način ispravljanja zuba? Zbog toga što folije na zubima nisu sve vreme i što je pritisak na zube umeren, ovom metodom je moguće ispraviti samo blaže i srednje teške nepravilnosti zuba. Još jedna primena ovih folija može biti u kombinaciji sa fiksnom protezom, kada se neka teža anomalija najpre nekoliko meseci tretira fiksnom protezom, a zatim se terapija dovršava folijama.",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2036,
				KategorijaId = 1007,
				KorisnikId = 2002,
				Naslov = "Prvi pregled ",
				Sadrzaj = "Prvi pregled čine:  anamneza – povijest bolesti, na prvom pregledu specijalist oralne kirurgije će kroz razgovor dobiti od pacijenta bitne informacije o njegovom zdravstvenom stanju klinički pregled u ustima-pregledom u ustima oralni će kirurg detaljno procijenti pacijentovo oralno zdravlje analiza različitih rtg snimaka- najčešće je to ortopan i intraoralni rtg, a u zadnje vrijeme i CBCT (CT čeljusti) uz pomoć kojih će specijalist oralne kirurgije postaviti ispravnu dijagnozu i odrediti je li i kada potrebno pristupiti oralnokirurškom zahvatu. Na prvom pregledu specijalist oralne kirurgije će kroz razgovor dobiti od pacijenta bitne informacije o njegovom zdravstvenom stanju, bolestima od kojih je prethodno bolovao ili još uvijek boluje, lijekovima koje uzima povremeno ili stalno, eventualnim fizičkim traumama (prometna nesreća, pad, udarac) i slično. Analiza rtg snimaka postupak je tijekom kojeg oralni kirurg pregledom različitih vrsta rtg snimaka, od kojih su najčešći:  ortopantomogram, intraoralni ciljani rtg snimak, CBCT snimak; Na taj način kirurg dobiva informacije koje nisu dostupne kliničkim pregledom (npr. postojanje upalnog procesa u kosti, lokalizacija neizraslog zuba, veličina i položaj ciste, debljina i širina kosti pri planiranju implantološke terapije i drugo).",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Clanak>().HasData(new WebAPI.Database.Clanak()
			{
				ClanakId = 2037,
				KategorijaId = 1007,
				KorisnikId = 2002,
				Naslov = "Oralnokirurški zahvati ",
				Sadrzaj = "Najčešći oralnokirurški zahvati povezani sa zubima i ustima su:  vađenje zuba i zubnih korijenova (ekstrakcija) alveotomija zuba (operacijsko vađenje, vađenje umnjaka) apikotomija (apicektomija) zuba-micanje vrška korijena zbog upale frenulektomija cistektomija kortikotomija VAĐENJE ZUBA  Vađenje zuba je kirurški zahvat tijekom kojeg oralni kirurg pomoću kliješta i drugih instrumenata uklanja iz usta zub koji je iz nekog razloga (upala, pucanje/trauma, prekobrojni zubi i dr.) potrebno izvaditi. ALVEOTOMIJA ZUBA  Alveotomija je kirurški zahvat tijekom kojeg se uklanja zub koji se djelomično ili potpuno nalazi u kosti i/ili ispod zubnog mesa (impaktirani i retinirani zubi, prekobrojni zubi i dr.), zbog čega je potrebno „otvoriti“ zubno meso i djelomično izbrusiti kost da bi se takav zub mogao izvaditi. FRENULEKTOMIJA  Frenulektomija je kirurški zahvat kojim se uklanja ili premješta mali nabor sluznice ispod gornje usne – frenulum kako bi se omogućilo pravilno postavljanje i spajanje gornjih prednjih zubi. Obično se provodi u sklopu ortodontske terapije.  CISTEKTOMIJA  Cistektomija je kirurški zahvat kojim se uklanjaju šuplje tvorbe u kosti čeljusti koje zovemo ciste. One mogu nastati iz raznih razloga (upala, trauma, razvojne nepravilnosti i dr.), a potrebno ih je ukloniti jer svojim rastom razaraju kost i mogu ugroziti zdravlje zubi.  KORTIKOTOMIJA  Kortikotomija predstavlja operativni zahvat koji se provodi na zubima koji postoje negdje u kosti gornje ili donje čeljusti, ali nisu nikli i ne vide se u zubnom nizu. ",
				DatumObjave = new DateTime(2020, 12, 4, 23, 24, 40),
			});
			modelBuilder.Entity<Ocjena>().HasData(new WebAPI.Database.Ocjena()
			{
				OcjenaId = 2,
				Ocjena1 = 9,
				PacijentId = 2012,
				ClanakId = 2011
			});
			modelBuilder.Entity<Ocjena>().HasData(new WebAPI.Database.Ocjena()
			{
				OcjenaId = 3,
				Ocjena1 = 7,
				PacijentId = 2012,
				ClanakId = 2006
			});
			modelBuilder.Entity<Ocjena>().HasData(new WebAPI.Database.Ocjena()
			{
				OcjenaId = 4,
				Ocjena1 = 10,
				PacijentId = 2009,
				ClanakId = 2011
			});
			modelBuilder.Entity<Ocjena>().HasData(new WebAPI.Database.Ocjena()
			{
				OcjenaId = 5,
				Ocjena1 = 0,
				PacijentId = 2009,
				ClanakId = 2006
			});
			modelBuilder.Entity<Ocjena>().HasData(new WebAPI.Database.Ocjena()
			{
				OcjenaId = 6,
				Ocjena1 = 10,
				PacijentId = 2009,
				ClanakId = 2037
			});
		}
	}
}
