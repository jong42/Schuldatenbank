# Schuldatenbank
Dieses Projekt dient als Demonstration dafür, wie eine Lehrer- und Schülerdatenbank in C# realisiert werden kann. Das Projekt ist inspiriert durch die [LUSD](https://www.sinc.de/lusd/) Datenbank.

## Tabellen

Schüler(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Klasse) <br />
Lehrer(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Fach1, Fach2, Fach3) <br />
Kurse (Fach, <ins>Lehrer</ins>, Klasse, <ins>Wochentag</ins>, <ins>Uhrzeit</ins>) <br />
Klausuren(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname</ins>, <ins>Prüfungsdatum</ins>, Note) <br />
Mitarbeitsnoten(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname, Note)</ins> <br />


## Future Work

Raumbelegungen hinzufügen <br />
Kurse, die weniger als einmal die Woche stattfinden <br />
Halbjahr berücksichtigen <br />
<br />

