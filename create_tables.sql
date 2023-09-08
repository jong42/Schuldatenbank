CREATE TABLE Lehrer (
	name varchar(100),
	vorname varchar(100),
	geburtsdatum date,
	fach1 varchar(100),
	fach2 varchar(100),
	fach3 varchar(100),
	PRIMARY KEY(name, vorname, geburtsdatum)	
	);
	
CREATE TABLE Schüler (
	name varchar(100),
	vorname varchar(100),
	geburtsdatum date,
	klasse varchar(10),
	PRIMARY KEY(name, vorname, geburtsdatum)
	);
	
CREATE TABLE Kurse (
	kursbezeichnung varchar(100) PRIMARY KEY,
	fach varchar(100),
	lehrername varchar(100),
	lehrervorname varchar(100),
	lehrergeburtsdatum date,
	klasse varchar(10),
	FOREIGN KEY (lehrername, lehrervorname, lehrergeburtsdatum) 
		REFERENCES Lehrer (name, vorname, geburtsdatum)
	);
	
CREATE TABLE Kurstermine (
	kursbezeichnung varchar(100),
	wochentag varchar(10),
	uhrzeit varchar(10),
	PRIMARY KEY(kursbezeichnung, wochentag, uhrzeit),
	FOREIGN KEY (kursbezeichnung) REFERENCES Kurse (kursbezeichnung)
	);
	
CREATE TABLE Klausurnoten (
	kursbezeichnung varchar(100),
	schülername varchar(100),
	schülervorname varchar(100),
	schülergeburtsdatum date,
	prüfungsdatum date,
	note NUMERIC,
	PRIMARY KEY(kursbezeichnung, schülername, schülervorname, schülergeburtsdatum, prüfungsdatum),
	FOREIGN KEY (kursbezeichnung) REFERENCES Kurse (kursbezeichnung),
	FOREIGN KEY (schülername, schülervorname, schülergeburtsdatum) 
		REFERENCES Schüler (name, vorname, geburtsdatum)
	);
	
CREATE TABLE Mitarbeitsnoten (
	kursbezeichnung varchar(100),
	schülername varchar(100),
	schülervorname varchar(100),
	schülergeburtsdatum date,
	note NUMERIC,
	PRIMARY KEY(kursbezeichnung, schülername, schülervorname, schülergeburtsdatum),
	FOREIGN KEY (kursbezeichnung) REFERENCES Kurse (kursbezeichnung),
	FOREIGN KEY (schülername, schülervorname, schülergeburtsdatum) 
		REFERENCES Schüler (name, vorname, geburtsdatum)
	);	
