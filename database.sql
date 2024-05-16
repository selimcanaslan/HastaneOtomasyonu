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


SELECT * FROM Doktor

SELECT * FROM Randevu

