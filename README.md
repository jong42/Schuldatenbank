# Schuldatenbank
Dieses Projekt dient als Demonstration dafür, wie eine Lehrer- und Schülerdatenbank in C# realisiert werden kann. Das Projekt ist inspiriert durch die [LUSD](https://www.sinc.de/lusd/) Datenbank.

## Geplante Features
 * Grundlegende Funktionen: Hinzufügen und Löschen von Schülern, Lehrern, Kursen
 * Zeitkonflikte zwischen Kursen erkennen
 * Automatisiert einen konfliktfreien Stundenplan für alle Klassen erstellen
 * Stundenplan für Klassen ausgeben
 * Stundenplan für Lehrer ausgeben
 * Noten berechnen und Zeugnisse generieren

## Tabellen

Schüler(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Klasse) <br />
Lehrer(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Fach1, Fach2, Fach3) <br />
Kurse (Fach, <ins>Lehrer</ins>, Klasse, <ins>Wochentag</ins>, <ins>Uhrzeit</ins>) <br />
Klausuren(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname</ins>, <ins>Prüfungsdatum</ins>, Note) <br />
Mitarbeitsnoten(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname, Note)</ins> <br />


## Weiterführende Arbeiten

Raumbelegungen hinzufügen <br />
Kurse, die weniger als einmal die Woche stattfinden <br />
Halbjahr berücksichtigen <br />
<br />

