-- adrese
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Milana Tepića', '7');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('Slovenija', 'Ljubljana', '1000', 'Kančeva ulica', '28');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Kralja Petra I Krađorđevića', '21');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Marije Bursać', '7');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Majke Jugovića', '9');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Prijedor', '79000', 'Vuka Karadžića', '31');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Doboj', '74000', 'Nikola Tesla', '4');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Veselina Masleše', '18');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Prvog Krajiškog korpusa', '39');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Kralja Petra I Karađorđevića', '60');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Trg Krajine', '5');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('Slovenija', 'Novo Mesto', '8000', 'Šmarješka cesta', '13');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Sarajevo', '71000', 'Hasiba Brankovića', '19');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Sarajevo', '71000', 'Jukićeva', '53');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Braće Jugovića', '26');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Majke Jugovića', '35');
INSERT INTO `mycinemadb`.`adresa` (`Drzava`, `Grad`, `PostanskiBroj`, `Ulica`, `Broj`) VALUES ('BiH', 'Banja Luka', '78000', 'Carice Milice', '22');

-- kino
INSERT INTO `mycinemadb`.`kino` (`Naziv`, `ADRESA_IdAdresa`) VALUES ('Cineplex Palas', '11');

-- telefon_kino
INSERT INTO `mycinemadb`.`telefon_kino` (`Telefon`, `KINO_Idkino`) VALUES ('051217409', '1');
INSERT INTO `mycinemadb`.`telefon_kino` (`Telefon`, `KINO_Idkino`) VALUES ('051217410', '1');
INSERT INTO `mycinemadb`.`telefon_kino` (`Telefon`, `KINO_Idkino`) VALUES ('051217411', '1');

-- zaposleni
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('2111995105009', 'Ana', 'Marković', 'ana.markovic@gmail.com', '1200', '1', '1');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('2908994104004', 'Nebojša', 'Jovanović', 'nebojsa.jovanovic@gmail.com', '950', '1', '3');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('2106999107022', 'Marija', 'Jovanović', 'marija.jovanovic@gmail.com', '950', '1', '4');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('1404975108101', 'Svjetlana', 'Blagojević', 'svjetlana.blagojevic@gmail.com', '1200', '1', '8');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('0208970106105', 'Ilija', 'Mijić', 'ilija.mijic@gmail.com', '950', '1', '9');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('1812994107109', 'Dubravka', 'Ducanović', 'dubravka.ducanovic@gmail.com', '950', '1', '10');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('2109993105104', 'Gordana', 'Džajić', 'gordana.dzajic@gmail.com', '950', '1', '14');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('0804992103109', 'Marko', 'Simić', 'marko.simic@gmail.com', '950', '1', '16');
INSERT INTO `mycinemadb`.`zaposleni` (`JMB`, `Ime`, `Prezime`, `Email`, `Plata`, `KINO_Idkino`, `ADRESA_IdAdresa`) VALUES ('1402996103101', 'Janko', 'Janković', 'janko.jankovic@gmail.com', '1200', '1', '17');

-- korisnicki_nalog
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('anaM', 'lozinka1', '1');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('svjetlanaB', 'lozinka2', '4');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('jankoJ', 'lozinka3', '9');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('nebojsaJ', 'lozinka4', '2');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('marijaJ', 'lozinka5', '3');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('ilijaM', 'lozinka6', '5');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('dubravkaD', 'lozinka7', '6');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('gordanaD', 'lozinka8', '7');
INSERT INTO `mycinemadb`.`korisnicki_nalog` (`KorisnickoIme`, `Lozinka`, `ZAPOSLENI_IdZaposleni`) VALUES ('markoS', 'lozinka9', '8');

-- telefon_zaposleni
INSERT INTO `mycinemadb`.`telefon_zaposleni` (`Telefon`, `ZAPOSLENI_IdZaposleni`) VALUES ('065444145', '4');

-- menadzer
INSERT INTO `mycinemadb`.`menadzer` (`ZAPOSLENI_IdZaposleni`) VALUES ('4');
INSERT INTO `mycinemadb`.`menadzer` (`ZAPOSLENI_IdZaposleni`) VALUES ('1');
INSERT INTO `mycinemadb`.`menadzer` (`ZAPOSLENI_IdZaposleni`) VALUES ('9');

-- ugovor
INSERT INTO `mycinemadb`.`ugovor` (`PocetakRadnogOdnosa`, `PrekidUgovora`, `MENADZER_ZAPOSLENI_IdZaposleni`, `ZAPOSLENI_IdZaposleni`) VALUES ('2020-12-01', '2021-12-01', '4', '2');
INSERT INTO `mycinemadb`.`ugovor` (`PocetakRadnogOdnosa`, `PrekidUgovora`, `MENADZER_ZAPOSLENI_IdZaposleni`, `ZAPOSLENI_IdZaposleni`) VALUES ('2020-06-06', '2021-06-06', '1', '3');

-- banka
INSERT INTO `mycinemadb`.`banka` (`Naziv`, `ADRESA_IdAdresa`) VALUES ('UniCredit Bank', '7');
INSERT INTO `mycinemadb`.`banka` (`Naziv`, `ADRESA_IdAdresa`) VALUES ('UniCredit Bank', '13');

-- telefon_banka
INSERT INTO `mycinemadb`.`telefon_banka` (`Telefon`, `BANKA_IdBanka`) VALUES ('051111222', '1');
INSERT INTO `mycinemadb`.`telefon_banka` (`Telefon`, `BANKA_IdBanka`) VALUES ('051222111', '2');

-- sala
INSERT INTO `mycinemadb`.`sala` (`Naziv`, `Tip`, `KINO_Idkino`) VALUES ('1', '2D', '1');
INSERT INTO `mycinemadb`.`sala` (`Naziv`, `Tip`, `KINO_Idkino`) VALUES ('2', '2D', '1');
INSERT INTO `mycinemadb`.`sala` (`Naziv`, `Tip`, `KINO_Idkino`) VALUES ('3', '3D', '1');

-- red
INSERT INTO `mycinemadb`.`red` (`BrojReda`, `SALA_IdSala`) VALUES ('1', '1');
INSERT INTO `mycinemadb`.`red` (`BrojReda`, `SALA_IdSala`) VALUES ('2', '1');
INSERT INTO `mycinemadb`.`red` (`BrojReda`, `SALA_IdSala`) VALUES ('3', '1');
INSERT INTO `mycinemadb`.`red` (`BrojReda`, `SALA_IdSala`) VALUES ('4', '1');
INSERT INTO `mycinemadb`.`red` (`BrojReda`, `SALA_IdSala`) VALUES ('5', '1');

-- sjediste
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('1', '1', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('2', '1', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('3', '1', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('4', '1', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('5', '1', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('1', '2', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('2', '2', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('3', '2', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('4', '2', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('5', '2', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('1', '3', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('2', '3', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('3', '3', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('4', '3', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('5', '3', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('1', '4', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('2', '4', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('3', '4', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('4', '4', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('5', '4', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('1', '5', '1');
INSERT INTO `mycinemadb`.`sjediste` (`BrojSjedista`, `RED_IdRed`, `RED_SALA_IdSala`) VALUES ('2', '5', '1');

-- film 
INSERT INTO `mycinemadb`.`film` (`Naziv`, `KratakOpis`, `Trajanje`) VALUES ('Bješe jednom','David, Petra i Alisa Lidlton uživaju u idiličnom djetinjstvu u Engleskoj krajem 19. vijeka. Oni najviše vole da se igraju u svojoj bašti i obližnjoj šumi, a dječiju živpisnu maštu podstiču roditelji Džek (David Oyelowo) i Rouz (Angelina Jolie)...', '95');
INSERT INTO `mycinemadb`.`film` (`Naziv`, `KratakOpis`, `Trajanje`) VALUES ('Scooby Doo!', 'U filmu ćemo saznati mnoge tajne i činjenice o omiljenoj ekipi koja već decenijama rješava najsloženije misterije i zadatke. Kako su se Scooby i Shaggy sreli, kako se dvojac zatim upoznao s mladim detektivima Fredom, Velmom i Daphne te kako su dospjeli do svog prvog slučaja...', '93');
INSERT INTO `mycinemadb`.`film` (`Naziv`, `KratakOpis`, `Trajanje`) VALUES ('Časovi persijskog', 'Film je nastao po istoimenoj kratkoj priči njemačkog pisca Volfgana Kolhase, i vodi nas kroz život jednog mladog Jevreja tokom njemačke okupacije, za vrijeme Drugog svjetskog rata. Njegova neobična snalažljivost i lukavost spasiće mu život....', '127');
INSERT INTO `mycinemadb`.`film` (`Naziv`, `KratakOpis`, `Trajanje`) VALUES ('Novi mutanti', 'Priča o pet mladih ljudi s opasnim sposobnostima koji se drže pod zaštitom na tajnoj lokaciji protiv njihove volje. Svaki od njih nosi teret tajanstvene prošlosti i moći koju ne mogu kontrolisati. Kad shvate da su \"pod zaštitom\" u još većoj opasnosti, i bivaju progonjeni od natprirodnog zla, njihovi najveći strahovi će se ostvariti...', '98');
INSERT INTO `mycinemadb`.`film` (`Naziv`, `KratakOpis`, `Trajanje`) VALUES ('Mulan', 'Kad kineski car izda dekret po kojem jedan muškarac u svakoj porodici mora služiti carskoj vojsci kako bi odbranili zemlju od sjevernih napadača, Hua Mulan, najstarija ćerka časnog ratnika, istupa umjesto svog bolesnog oca...', '115');

-- zanr
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('avantura');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('drama');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('fantazija');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('SF');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('horor');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('komedija');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('akcija');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('misterija');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('romantika');
INSERT INTO `mycinemadb`.`zanr` (`Naziv`) VALUES ('triler');


-- film_zanr
INSERT INTO `mycinemadb`.`film_zanr` (`ZANR_IdZanr`, `FILM_IdFilm`) VALUES ('1', '1');
INSERT INTO `mycinemadb`.`film_zanr` (`ZANR_IdZanr`, `FILM_IdFilm`) VALUES ('2', '1');
INSERT INTO `mycinemadb`.`film_zanr` (`ZANR_IdZanr`, `FILM_IdFilm`) VALUES ('3', '1');
INSERT INTO `mycinemadb`.`film_zanr` (`ZANR_IdZanr`, `FILM_IdFilm`) VALUES ('1', '2');
INSERT INTO `mycinemadb`.`film_zanr` (`ZANR_IdZanr`, `FILM_IdFilm`) VALUES ('2', '3');
INSERT INTO `mycinemadb`.`film_zanr` (`ZANR_IdZanr`, `FILM_IdFilm`) VALUES ('4', '4');
INSERT INTO `mycinemadb`.`film_zanr` (`ZANR_IdZanr`, `FILM_IdFilm`) VALUES ('1', '5');

-- lice
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Brenda', 'Chapman');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('David', ' Oyelowo');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Angelina', 'Jolie');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Marissa Kate', 'Goodhill');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Tony', 'Cervone');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Vadim ', 'Perelman');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Ilya', 'Tsofin');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Lars', ' Eidinger');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Nahuel ', 'Perez');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Niki', 'Caro');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Yifei ', 'Liu');
INSERT INTO `mycinemadb`.`lice` (`Ime`, `Prezime`) VALUES ('Jet', 'Li');


-- vrsta_angazmana
INSERT INTO `mycinemadb`.`vrsta_angazmana` (`Naziv`) VALUES ('režiser');
INSERT INTO `mycinemadb`.`vrsta_angazmana` (`Naziv`) VALUES ('scenarista');
INSERT INTO `mycinemadb`.`vrsta_angazmana` (`Naziv`) VALUES ('glumac');
INSERT INTO `mycinemadb`.`vrsta_angazmana` (`Naziv`) VALUES ('narator');

-- angazman
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('1', '1', '1');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('4', '2', '1');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('2', '3', '1');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('3', '3', '1');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('5', '1', '2');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('6', '1', '3');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('7', '2', '3');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('8', '3', '3');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('9', '3', '3');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('10', '1', '5');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('11', '3', '5');
INSERT INTO `mycinemadb`.`angazman` (`LICE_IdLica`, `VRSTA_ANGAZMANA_IdVrstaAngazmana`, `FILM_IdFilm`) VALUES ('12', '3', '5');

-- recepcioner
INSERT INTO `mycinemadb`.`recepcioner` (`ZAPOSLENI_IdZaposleni`) VALUES ('2');
INSERT INTO `mycinemadb`.`recepcioner` (`ZAPOSLENI_IdZaposleni`) VALUES ('3');
INSERT INTO `mycinemadb`.`recepcioner` (`ZAPOSLENI_IdZaposleni`) VALUES ('6');
INSERT INTO `mycinemadb`.`recepcioner` (`ZAPOSLENI_IdZaposleni`) VALUES ('7');

-- projekcija
INSERT INTO `mycinemadb`.`projekcija` (`SALA_IdSala`, `DatumIVrijemePrikazivanja`, `FILM_IdFilm`, `Cijena`) VALUES ('1', '2021-03-03 18:00:00', '1', '3');
INSERT INTO `mycinemadb`.`projekcija` (`SALA_IdSala`, `DatumIVrijemePrikazivanja`, `FILM_IdFilm`, `Cijena`) VALUES ('1', '2021-05-03 20:10:00', '5', '5');
INSERT INTO `mycinemadb`.`projekcija` (`SALA_IdSala`, `DatumIVrijemePrikazivanja`, `FILM_IdFilm`, `Cijena`) VALUES ('1', '2021-03-05 15:00:00', '2', '4');
INSERT INTO `mycinemadb`.`projekcija` (`SALA_IdSala`, `DatumIVrijemePrikazivanja`, `FILM_IdFilm`, `Cijena`) VALUES ('1', '2021-03-05 12:10:00', '3', '5');
INSERT INTO `mycinemadb`.`projekcija` (`SALA_IdSala`, `DatumIVrijemePrikazivanja`, `FILM_IdFilm`, `Cijena`) VALUES ('1', '2021-03-05 10:00:00', '4', '4');

-- karta
INSERT INTO `mycinemadb`.`karta` (`DatumIVrijemeIzdavanja`, `RECEPCIONER_ZAPOSLENI_IdZaposleni`, `PROJEKCIJA_SALA_IdSala`, `PROJEKCIJA_FILM_IdFilm`, `PROJEKCIJA_DatumIVrijemePrikazivanja`, `SJEDISTE_BrojSjedista`, `SJEDISTE_RED_IdRed`) VALUES ('2020-03-03 17:50:00', '2', '1', '1', '2021-03-03 18:00:00', '1', '1');
INSERT INTO `mycinemadb`.`karta` (`DatumIVrijemeIzdavanja`, `RECEPCIONER_ZAPOSLENI_IdZaposleni`, `PROJEKCIJA_SALA_IdSala`, `PROJEKCIJA_FILM_IdFilm`, `PROJEKCIJA_DatumIVrijemePrikazivanja`, `SJEDISTE_BrojSjedista`, `SJEDISTE_RED_IdRed`) VALUES ('2020-03-03 17:50:15', '2', '1', '5', '2021-05-03 20:10:00', '2', '1');

-- racun
INSERT INTO `mycinemadb`.`racun` (`DatumIVrijemeIzdavanja`, `RECEPCIONER_ZAPOSLENI_IdZaposleni`) VALUES ('2020-12-03 17:52:00', '2');
INSERT INTO `mycinemadb`.`racun` (`DatumIVrijemeIzdavanja`, `RECEPCIONER_ZAPOSLENI_IdZaposleni`) VALUES ('2020-12-03 17:52:30', '2');

-- kategorija
INSERT INTO `mycinemadb`.`kategorija` (`Naziv`) VALUES ('gazirano piće');
INSERT INTO `mycinemadb`.`kategorija` (`Naziv`) VALUES ('mineralna voda');
INSERT INTO `mycinemadb`.`kategorija` (`Naziv`) VALUES ('prirodna voda');
INSERT INTO `mycinemadb`.`kategorija` (`Naziv`) VALUES ('čips');
INSERT INTO `mycinemadb`.`kategorija` (`Naziv`) VALUES ('kikiriki');
INSERT INTO `mycinemadb`.`kategorija` (`Naziv`) VALUES ('kokice');

-- proizvod
INSERT INTO `mycinemadb`.`proizvod` (`Naziv`, `Cijena`, `KATEGORIJA_IdKategorija`) VALUES ('Coca Cola', '2.5', '1');
INSERT INTO `mycinemadb`.`proizvod` (`Naziv`, `Cijena`, `KATEGORIJA_IdKategorija`) VALUES ('Jana', '1.0', '3');
INSERT INTO `mycinemadb`.`proizvod` (`Naziv`, `Cijena`, `KATEGORIJA_IdKategorija`) VALUES ('Jamnica', '1.5', '2');
INSERT INTO `mycinemadb`.`proizvod` (`Naziv`, `Cijena`, `KATEGORIJA_IdKategorija`) VALUES ('Clipsy', '1.5', '4');
INSERT INTO `mycinemadb`.`proizvod` (`Naziv`, `Cijena`, `KATEGORIJA_IdKategorija`) VALUES ('Gud', '1.8', '5');
INSERT INTO `mycinemadb`.`proizvod` (`Naziv`, `Cijena`, `KATEGORIJA_IdKategorija`) VALUES ('Popcorn', '2.5', '6');

-- stavka_racuna
INSERT INTO `mycinemadb`.`stavka_racuna` (`Kolicina`, `RACUN_IdRacun`, `PROIZVOD_IdProizvod`) VALUES ('2', '1', '1');
INSERT INTO `mycinemadb`.`stavka_racuna` (`Kolicina`, `RACUN_IdRacun`, `PROIZVOD_IdProizvod`) VALUES ('1', '1', '2');
INSERT INTO `mycinemadb`.`stavka_racuna` (`Kolicina`, `RACUN_IdRacun`, `PROIZVOD_IdProizvod`) VALUES ('2', '1', '4');

-- skladiste
INSERT INTO `mycinemadb`.`skladiste` (`NazivSkladiste`) VALUES ('Cineplex Skladiste 1');
INSERT INTO `mycinemadb`.`skladiste` (`NazivSkladiste`) VALUES ('Cineplex Skladiste 2');

-- skladiste_proizvod
INSERT INTO `mycinemadb`.`skladiste_proizvod` (`SKLADISTE_IdSkladiste`, `PROIZVOD_IdProizvod`, `KolicinaNaStanju`) VALUES ('1', '1', '1150');
INSERT INTO `mycinemadb`.`skladiste_proizvod` (`SKLADISTE_IdSkladiste`, `PROIZVOD_IdProizvod`, `KolicinaNaStanju`) VALUES ('1', '2', '1055');
INSERT INTO `mycinemadb`.`skladiste_proizvod` (`SKLADISTE_IdSkladiste`, `PROIZVOD_IdProizvod`, `KolicinaNaStanju`) VALUES ('1', '3', '945');
INSERT INTO `mycinemadb`.`skladiste_proizvod` (`SKLADISTE_IdSkladiste`, `PROIZVOD_IdProizvod`, `KolicinaNaStanju`) VALUES ('1', '4', '927');
INSERT INTO `mycinemadb`.`skladiste_proizvod` (`SKLADISTE_IdSkladiste`, `PROIZVOD_IdProizvod`, `KolicinaNaStanju`) VALUES ('1', '5', '556');
INSERT INTO `mycinemadb`.`skladiste_proizvod` (`SKLADISTE_IdSkladiste`, `PROIZVOD_IdProizvod`, `KolicinaNaStanju`) VALUES ('1', '6', '321');

-- magacioner
INSERT INTO `mycinemadb`.`magacioner` (`ZAPOSLENI_IdZaposleni`, `SKLADISTE_IdSkladista`) VALUES ('5', '1');
INSERT INTO `mycinemadb`.`magacioner` (`ZAPOSLENI_IdZaposleni`, `SKLADISTE_IdSkladista`) VALUES ('8', '2');

-- dobavljac
INSERT INTO `mycinemadb`.`dobavljac` (`Naziv`, `ADRESA_IdAdresa`) VALUES ('Dobavljač 1', '2');
INSERT INTO `mycinemadb`.`dobavljac` (`Naziv`, `ADRESA_IdAdresa`) VALUES ('Dobavljač 2', '12');

-- telefon_dobavljac
INSERT INTO `mycinemadb`.`telefon_dobavljac` (`Telefon`, `DOBAVLJAC_IdDobavljac`) VALUES ('003865121223', '1');
INSERT INTO `mycinemadb`.`telefon_dobavljac` (`Telefon`, `DOBAVLJAC_IdDobavljac`) VALUES ('003865122333', '2');

-- faktura
INSERT INTO `mycinemadb`.`faktura` (`DatumIVrijemeIzdavanjaFakture`, `DOBAVLJAC_IdDobavljac`) VALUES ('2020-12-05 13:54:00', '1');

-- stavka_fakture
INSERT INTO `mycinemadb`.`stavka_fakture` (`FAKTURA_IdFaktura`, `PROIZVOD_IdProizvod`, `Kolicina`) VALUES ('1', '1 ', '50');
INSERT INTO `mycinemadb`.`stavka_fakture` (`FAKTURA_IdFaktura`, `PROIZVOD_IdProizvod`, `Kolicina`) VALUES ('1', '2', '50');
INSERT INTO `mycinemadb`.`stavka_fakture` (`FAKTURA_IdFaktura`, `PROIZVOD_IdProizvod`, `Kolicina`) VALUES ('1', '3', '50');

-- narudzba
INSERT INTO `mycinemadb`.`narudzba` (`DatumIVrijemeNarudzbe`, `MAGACIONER_ZAPOSLENI_IdZaposleni`, `DOBAVLJAC_IdDobavljac`) VALUES ('2020-12-04', '5', '1');

-- stavka_narudzbe
INSERT INTO `mycinemadb`.`stavka_narudzbe` (`Kolicina`, `NARUDZBA_IdNarudzba`, `PROIZVOD_IdProizvod`) VALUES ('50', '1', '1');
INSERT INTO `mycinemadb`.`stavka_narudzbe` (`Kolicina`, `NARUDZBA_IdNarudzba`, `PROIZVOD_IdProizvod`) VALUES ('50', '1', '2');
INSERT INTO `mycinemadb`.`stavka_narudzbe` (`Kolicina`, `NARUDZBA_IdNarudzba`, `PROIZVOD_IdProizvod`) VALUES ('50', '1', '3');

-- racun_u_banci
INSERT INTO `mycinemadb`.`racun_u_banci` (`BrojRacuna`, `DOBAVLJAC_IdDobavljac`, `BANKA_IdBanke`) VALUES ('551-003-12345678-34', '1', '1');
INSERT INTO `mycinemadb`.`racun_u_banci` (`BrojRacuna`, `BANKA_IdBanke`, `KINO_Idkino`) VALUES ('551-004-12345678-12', '1', '1');