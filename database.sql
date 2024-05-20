CREATE TABLE Hasta(
	id int identity(1,1)PRIMARY KEY CLUSTERED,
	ad varchar(30),
	soyad varchar(30),
	dogumTarihi DateTime,
	tckNo varchar(11),
	cinsiyet varchar(10),
	adres varchar(255),
	email varchar(100),
	sifre varchar(30)
);

INSERT Hasta VALUES ('Muhammet Yusuf','ASLAN',GETDATE(),'01234567890','Erkek','Mersin','myaslan333@gmail.com','myaslan333')

CREATE TABLE Sekreter(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	ad varchar(30),
	soyad varchar(30),
	dogumTarihi DateTime,
	tckNo varchar(11),
	cinsiyet varchar(10),
	adres varchar(255),
	email varchar(100),
	sifre varchar(30)
);

CREATE TABLE Doktor(
	id int identity(1,1) PRIMARY KEY CLUSTERED,
	ad varchar(30),
	soyad varchar(30),
	dogumTarihi DateTime,
	tckNo varchar(11),
	cinsiyet varchar(10),
	adres varchar(255),
	email varchar(100),
	sifre varchar(30),
	brans varchar(50)
);
INSERT Doktor VALUES ('Gulseren','Gul','1969-05-11 07:46:28.453','32132132132','KADIN','Fethiye','gulseren@gmail.com','gulseren','Kadin Dogum')
CREATE TABLE Randevu (
	id int identity(1,1) PRIMARY KEY,
	hastaId int FOREIGN KEY (hastaId) REFERENCES Hasta(id) ON DELETE CASCADE ON UPDATE CASCADE,
	doctorId int FOREIGN KEY (doctorId) REFERENCES Doktor(id) ON DELETE CASCADE ON UPDATE CASCADE,
	bolum varchar(30),
	tarih DateTime,
	saat varchar(30),
	sonuc nvarchar(max)
);

CREATE TABLE Bolumler (
	id int identity(1,1),
	bolumAdi varchar(30)
);

CREATE TABLE RandevuSaatleri (
	id int identity(1,1) PRIMARY KEY,
	saat varchar(20)
);

GO
CREATE PROCEDURE BugununRandevulari
	@bugun DateTime
AS
BEGIN
SELECT Hasta.id as 'hasta_id', Doktor.ad + ' ' + Doktor.soyad as 'doktor_ad', Hasta.ad + ' ' + Hasta.soyad as 'hasta_ad',
Hasta.cinsiyet as 'cinsiyet',bolum,FORMAT(tarih,'dd MMMM yyyy', 'tr-TR') as 'tarih',saat,sonuc FROM Randevu
INNER JOIN Doktor ON Doktor.id = Randevu.doctorId INNER JOIN Hasta ON Hasta.id = Randevu.hastaId WHERE FORMAT(Randevu.tarih, 'yyyy-MM-dd') = FORMAT(@bugun, 'yyyy-MM-dd')
END;



SELECT * FROM Doktor

SELECT * FROM Hasta

