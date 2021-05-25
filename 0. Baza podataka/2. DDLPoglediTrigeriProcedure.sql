-- procedura za pronalazak maxId zaposlenog
DROP PROCEDURE IF EXISTS maxID_Zaposlenog;
delimiter $$
CREATE PROCEDURE maxID_Zaposlenog(OUT pMaxId INT)
BEGIN
SELECT max(IdZaposleni) INTO pMaxId
FROM zaposleni;
END $$
delimiter ;

CALL maxID_Zaposlenog(@maxId);
SELECT @maxId;

-- procedura za izvjetsaj karata na dnevnom nivou
DROP PROCEDURE IF EXISTS izvjestaj;
delimiter $$
CREATE PROCEDURE izvjestaj(OUT pBrojKarata INT, OUT pUkupnaCijena DECIMAL)
BEGIN
SELECT COUNT(*), SUM(p.Cijena) INTO pBrojKarata, pUkupnaCijena
FROM karta k 
INNER JOIN projekcija p ON p.SALA_IdSala=k.PROJEKCIJA_SALA_IdSala AND p.DatumIVrijemePrikazivanja=k.PROJEKCIJA_DatumIVrijemePrikazivanja AND p.FILM_IdFilm=k.PROJEKCIJA_FILM_IdFilm
WHERE DATE_FORMAT(k.DatumIVrijemeIzdavanja,'%y-%m-%d') = DATE_FORMAT(sysdate(),'%y-%m-%d');
END $$
delimiter ;

CALL izvjestaj(@brojKarata, @ukupnaCijena);
SELECT @brojKarata, @ukupnaCijena;


-- pogled - informacije o zaposlenom
DROP VIEW IF EXISTS zaposleni_info;
CREATE VIEW zaposleni_info AS 
SELECT z.IdZaposleni, z.JMB, z.Ime, z.Prezime, z.Email, z.Plata, z.KINO_Idkino, k.Naziv, z.ADRESA_IdAdresa, CONCAT(a.Drzava, ', ' , a.Grad, ', ' , a.PostanskiBroj, ', ' , a.Ulica,  ', ', a.Broj) AS 'Adresa'
FROM ZAPOSLENI z 
INNER JOIN KINO k ON k.IdKino=z.KINO_IdKino
INNER JOIN ADRESA a ON a.IdAdresa=z.ADRESA_IdAdresa;

SELECT * FROM zaposleni_info;


-- triger za brisanje ugovora nakon brisanja zaposlenog
DROP TRIGGER IF EXISTS brisi_ugovor;
DELIMITER $$
CREATE TRIGGER brisi_ugovor BEFORE DELETE ON zaposleni
FOR EACH ROW 
BEGIN
DELETE FROM ugovor 
WHERE OLD.IdZaposleni=UGOVOR.ZAPOSLENI_IdZaposleni;
END $$
DELIMITER ;


-- pogled - infomacije o kinu
DROP VIEW IF EXISTS kino_info;
CREATE VIEW kino_info as 
SELECT k.Idkino, k.Naziv, GROUP_CONCAT(t.Telefon SEPARATOR ', ') AS 'Telefon', CONCAT(a.Drzava, ', ', a.Grad, ', ', a.PostanskiBroj, ', ', a.Ulica, ', ', a.Broj) AS 'Adresa'
FROM kino k
INNER JOIN ADRESA a ON k.ADRESA_IdAdresa=a.IdAdresa
INNER JOIN TELEFON_KINO t ON k.IdKino=t.KINO_IdKino
GROUP BY k.Naziv;

SELECT * FROM kino_info;

-- ispis filmova sa njihovim zanrovima
CREATE VIEW film_info AS
SELECT f.IdFilm, f.naziv, f.KratakOpis, f.Trajanje, GROUP_CONCAT(z.Naziv SEPARATOR ',') AS 'ZanrFilma'
FROM film_zanr fz
INNER JOIN film f ON fz.FILM_IdFilm=f.IdFilm
INNER JOIN zanr z ON fz.ZANR_IdZanr=z.IdZanr
GROUP BY f.Naziv;

SELECT * FROM film_info;

-- procedura za pronalazak maxId filma
DROP PROCEDURE IF EXISTS maxID_Filma;
delimiter $$
CREATE PROCEDURE maxID_Filma(OUT pMaxId INT)
BEGIN
SELECT max(IdFilm) INTO pMaxId
FROM film;
END $$
delimiter ;

CALL maxId_Filma(@maxId);
SELECT @maxId;

-- triger za brisanje tabele film-zanr i angazman prije brisanja tabele filma
DROP TRIGGER IF EXISTS brisi_filmZanr;
DELIMITER $$
CREATE TRIGGER brisi_filmZanr BEFORE DELETE ON film
FOR EACH ROW 
BEGIN
DELETE FROM film_zanr
WHERE OLD.IdFilm=film_zanr.FILM_IdFilm;
DELETE FROM angazman
WHERE OLD.IdFilm=angazman.FILM_IdFilm;
DELETE FROM projekcija
WHERE OLD.IdFilm=projekcija.FILM_IdFilm;
END $$
DELIMITER ;

-- triger za brisanje tabele film-zanr prije azuriranja tabele filma
DROP TRIGGER IF EXISTS brisi_filmZanrUpdate;
DELIMITER $$
CREATE TRIGGER brisi_filmZanrUpdate BEFORE UPDATE ON film
FOR EACH ROW 
BEGIN
DELETE FROM film_zanr 
WHERE OLD.IdFilm=film_zanr.FILM_IdFilm;
END $$
DELIMITER ;


-- ispis lica sa njihovim angazmanima
DROP VIEW IF EXISTS lice_info;
CREATE VIEW lice_info AS
SELECT l.IdLice, l.Ime, l.Prezime, GROUP_CONCAT(va.Naziv SEPARATOR ',') AS 'Vrsta_angazmana'
FROM angazman a
INNER JOIN lice l ON a.LICE_IdLica=l.IdLice
INNER JOIN vrsta_angazmana va ON va.IdVrstaAngazmana=a.VRSTA_ANGAZMANA_IdVrstaAngazmana
GROUP BY l.Ime;

SELECT * FROM lice_info; 


-- procedura za pronalazak maxIdLica
DROP PROCEDURE IF EXISTS maxID_Lica;
delimiter $$
CREATE PROCEDURE maxID_Lica(OUT pMaxId INT)
BEGIN
SELECT max(IdLice) INTO pMaxId
FROM lice;
END $$
delimiter ;

CALL maxId_Lica(@maxId);
SELECT @maxId;

-- triger za brisanje tabele angazman prije brisanja tabele lice
DROP TRIGGER IF EXISTS brisi_angazman;
DELIMITER $$
CREATE TRIGGER brisi_angazman BEFORE DELETE ON lice
FOR EACH ROW 
BEGIN
DELETE FROM angazman 
WHERE OLD.IdLice=angazman.LICE_IdLica;
END $$
DELIMITER ;

-- triger za brisanje tabele angazman prije azuriranja tabele lice
DROP TRIGGER IF EXISTS brisi_angazmanUpdate;
DELIMITER $$
CREATE TRIGGER brisi_angazmanUpdate BEFORE UPDATE ON lice
FOR EACH ROW 
BEGIN
DELETE FROM angazman 
WHERE OLD.IdLice=angazman.LICE_IdLica;
END $$
DELIMITER ;



-- procedura za provjeru sjedista prilikom izdavanja karte
DROP PROCEDURE IF EXISTS izdata;
delimiter $$
CREATE PROCEDURE izdata(IN pSala INT, IN pFilm INT, IN pDatumPrikazivanja DATETIME, IN pSjediste INT, IN pRed INT, OUT  pIzdata INT)
BEGIN
SELECT count(*) INTO pIzdata
FROM karta 
WHERE PROJEKCIJA_SALA_IdSala = pSala AND PROJEKCIJA_FILM_IdFilm = pFilm AND PROJEKCIJA_DatumIVrijemePrikazivanja = pDatumPrikazivanja AND SJEDISTE_BrojSjedista = pSjediste AND SJEDISTE_RED_IdRed = pRed;
-- SELECT max(IdZaposleni) INTO pMaxId
END $$
delimiter ;

CALL izdata('1', '1', '2020-12-03 18:00:00', '1', '1', @pIzdata);
SELECT @pIzdata;