# Schuldatenbank
Dieses Projekt dient als Demonstration dafür, wie eine Lehrer- und Schülerdatenbank in C# realisiert werden kann. Das Projekt ist inspiriert durch die [LUSD](https://www.sinc.de/lusd/) Datenbank. Die Datenbank soll vor allem dazu dienen, Schulnoten und Stundenpläne zu verwalten. Wichtige Entitäten in der Datenbank sind Lehrer, Schüler, Klassen, Kurse und Noten.

## Geplante Features
 * Grundlegende Funktionen: Hinzufügen und Löschen von Schülern, Lehrern, Kursen, Noten
 * Zeitkonflikte zwischen Kursen erkennen
 * Automatisiert einen konfliktfreien Stundenplan für alle Klassen erstellen
 * Stundenplan für Klassen ausgeben
 * Stundenplan für Lehrer ausgeben
 * Noten berechnen und Zeugnisse generieren

## ER - Diagramm

![ER_Diagramm (1)](https://github.com/jong42/Schuldatenbank/assets/18439476/35c8dffc-3844-4192-b460-09eac97e379f)

**Erläuterung:** <br />
Ein Lehrer kann mehrere Kurse unterrichten, ein Kurs wird aber immer von genau einem Lehrer unterrichtet. Ein Kurs kann an mehreren Kursterminen stattfinden, ein Kurstermin gehört aber immer zu genau einem Kurs. Ein Kurs wird von genau einer Klasse besucht, eine Klasse besucht jedoch mehrere Kurse. Eine Klasse enthält mehrere Schüler, ein Schüler gehört zu genau einer Klasse. Schüler erhalten Mitarbeitsnoten, eine Mitarbeitsnote gehört aber immer zu genau einem Schüler. Schüler erhalten ebenso Klausurnoten, eine Klausurnote gehört immer zu genau einem Schüler. In Kursen werden Mitarbeitsnoten vergeben: Mehrere Mitarbeitsnoten können in einem Kurs vergeben werden, eine Mitarbeitsnote gehört immer zu genau einem Kurs. In Kursen werden ebenso Klausurnoten vergeben: Mehrere Klausurnoten können in einem Kurs vergeben werden, eine Klausurnote gehört immer zu genau einem Kurs.

## Tabellen

* Lehrer(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Fach1, Fach2, Fach3) <br />
* Schüler(<ins>Name</ins>, <ins>Vorname</ins>, <ins>Geburtsdatum</ins>, Klasse) <br />
* Kurse (<ins>Kursbezeichnung</ins>, Fach, Lehrer, Klasse) <br />
* Kurstermine (<ins>Kursbezeichnung</ins>,  <ins>Wochentag</ins>, <ins>Uhrzeit</ins> ) <br />
* Klausurnoten(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname</ins>,  <ins>Schüler-Geburtsdatum</ins>, <ins>Prüfungsdatum</ins>, Note) <br />
* Mitarbeitsnoten(<ins>Kurs</ins>, <ins>Schülername</ins>, <ins>Schülervorname,  <ins>Schüler-Geburtsdatum</ins>, Note)</ins> <br />

**Erläuterung:** <br />
Lehrer haben einen Namen, Vornamen und ein Geburtsdatum. Durch diese drei Eigenschaften kann ein Lehrer eindeutig identifiziert werden. Lehrer haben außerdem bis zu drei Fächer, die sie unterrichten können. Schüler haben ebenfalls Namen, Vornamen und ein Geburtsdatum, und können durch diese Eigenschaften eindeutig identifiziert werden. Schüler gehören zu einer Klasse. Klassen belegen Kurse, in denen sie von einem Lehrer in einem Fach unterrichtet werden. Kurse werden durch ihre Kursbezeichnung identifiziert. Kurse finden zu bestimmten Terminen statt, ein Kurstermin wird duch den dazugehörigen Kurs sowie den Wochentag und die Uhrzeit, an dem er stattfindet, identifiziert. Schüler erhalten Klausurnoten und Mitarbeitsnoten in den einzelnen Kursen. Eine Note gehört zu einem Schüler, der wiederum durch Name, Vorname und Geburtsdatum identifiziert wird. Diese drei Attribute sowie der Kursname sind notwendig, um eine Note eindeutig zu identifizieren. Bei Klausurnoten ist zusätzlich noch das Datum der Klausur notwendig, da innerhalb eines Kurses mehrere Klausuren geschrieben werden. Bei Mitarbeitsnoten ist dies nicht notwendig, da es in einem Kurs nur eine Mitarbeitsnote pro Schüler gibt. Schließlich muss natürlich auch die Note selbst als Eintrag enthalten sein.

## Weiterführende Arbeiten

Raumbelegungen hinzufügen <br />
Kurse, die weniger als einmal die Woche stattfinden <br />
Halbjahr berücksichtigen <br />
Schüler wechselt Klasse <br />

