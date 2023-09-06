# Schuldatenbank
Dieses Projekt dient als Demonstration dafür, wie eine Lehrer- und Schülerdatenbank in C# realisiert werden kann. Das Projekt ist inspiriert durch die [LUSD](https://www.sinc.de/lusd/) Datenbank.

## Geplante Features
 * Grundlegende Funktionen: Hinzufügen und Löschen von Schülern, Lehrern, Kursen
 * Zeitkonflikte zwischen Kursen erkennen
 * Automatisiert einen konfliktfreien Stundenplan für alle Klassen erstellen
 * Stundenplan für Klassen ausgeben
 * Stundenplan für Lehrer ausgeben
 * Noten berechnen und Zeugnisse generieren

## ER - Diagramm
Die Datenbank soll vor allem dazu dienen, Schulnoten und Stundenpläne zu verwalten. Wichtige Entitäten in der Datenbank sind daher Lehrer, Schüler, Klassen, Kurse und Noten. Es gibt folgende Beziehungen zwischen den Entitäten: <br />
Ein Lehrer kann mehrere Kurse unterrichten, ein Kurs wird aber immer von genau einem Lehrer unterrichtet. Ein Kurs kann an mehreren Kursterminen stattfinden, ein Kurstermin gehört aber immer zu genau einem Kurs. Ein Kurs wird von genau einer Klasse besucht, eine Klasse besucht jedoch mehrere Kurse. Eine Klasse enthält mehrere Schüler, ein Schüler gehört zu genau einer Klasse. Schüler erhalten Mitarbeitsnoten, eine Mitarbeitsnote gehört aber immer zu genau einem Schüler. Schüler erhalten ebenso Klausurnoten, eine Klausurnote gehört immer zu genau einem Schüler. In Kursen werden Mitarbeitsnoten vergeben: Mehrere Mitarbeitsnoten können in einem Kurs vergeben werden, eine Mitarbeitsnote gehört immer zu genau einem Kurs. In Kursen werden ebenso Klausurnoten vergeben: Mehrere Klausurnoten können in einem Kurs vergeben werden, eine Klausurnote gehört immer zu genau einem Kurs.


![ER_Diagramm (1)](https://github.com/jong42/Schuldatenbank/assets/18439476/35c8dffc-3844-4192-b460-09eac97e379f)


## Tabellen

Lehrer haben einen Namen, Vornamen und ein Geburtsdatum. Durch diese drei Eigenschaften kann ein Lehrer eindeutig identifiziert werden. Lehrer haben außerdem bis zu drei Fächer, die sie unterrichten können. Lehrer unterrichten Kurse. In einem Kurs wird ein bestimmtes Fach unterrichtet, der Kurs findet regelmäßig an einem bestimmten Wochentag und zu einer bestimmten Uhrzeit statt. Durch Wochentag und Uhrzeit sowie den unterrichtenden Lehrer wird ein Kurs eindeutig identifiziert.

Schüler(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Klasse) <br />
Lehrer(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Fach1, Fach2, Fach3) <br />
Kurse (Fach, <ins>Lehrer</ins>, Klasse, <ins>Wochentag</ins>, <ins>Uhrzeit</ins>) <br />
Klausuren(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname</ins>, <ins>Prüfungsdatum</ins>, Note) <br />
Mitarbeitsnoten(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname, Note)</ins> <br />


## Weiterführende Arbeiten

Raumbelegungen hinzufügen <br />
Kurse, die weniger als einmal die Woche stattfinden <br />
Halbjahr berücksichtigen <br />
Schüler wechselt Klasse <br />

