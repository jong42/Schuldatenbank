# Schuldatenbank
Dieses Projekt dient als Demonstration dafür, wie eine Lehrer- und Schülerdatenbank in C# realisiert werden kann. Das Projekt ist inspiriert durch die [LUSD](https://www.sinc.de/lusd/) Datenbank. Die Datenbank soll vor allem dazu dienen, Schulnoten und Stundenpläne zu verwalten. Wichtige Entitäten in der Datenbank sind Lehrer, Schüler, Klassen, Kurse und Noten.

## Geplante Features
 * Grundlegende Funktionen: Hinzufügen und Löschen von Schülern, Lehrern, Kursen, Noten
 * Zeitkonflikte zwischen Kursen erkennen
 * Automatisiert einen konfliktfreien Stundenplan für alle Klassen erstellen
 * Stundenplan für Klassen ausgeben
 * Stundenplan für Lehrer ausgeben
 * Noten berechnen und Zeugnisse generieren

## Voraussetzungen

* psql
* Visual Studio Code mit C# Extension (TODO: Welche Extensions genau?)
  
## Anleitung

### Erstellung der Datenbank
1. Öffnen Sie psql, indem Sie `postgres=# psql -U username` in der Kommandozeile eingeben, wobei `username` durch den PostgreSQL Nutzernamen zu ersetzen ist (default: `postgres=# psql -U postgres`)
2. Geben Sie `CREATE DATABASE schuldatenbank` ein
3. Schließen Sie psql mit `\q`
4. Erstellen Sie die (leeren) Tabellen in der Datenbank, indem Sie `psql -U username -d myDataBase -a -f create_tabels.sql` in der Kommandozeile eingeben, wobei `username` durch den PostgreSQL Nutzernamen zu ersetzen ist

### Füllen der Datenbank
5. Um die Datenbank mit künstlichen Daten zu füllen, starten Sie ein neues Terminal in Visual Studio Code und geben Sie folgenden Befehl ein: `dotnet run fill_db`

### Interaktion mit der Datenbank
6. Um einen Eintrag zur Lehrertabelle hinzuzufügen, geben Sie folgenden Befehl ein: `dotnet run add_teacher NAME VORNAME GEBDATUM FACH1 FACH2 FACH3`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run add_teacher Mustermann Max 01.01.1980 Deutsch Mathe Englisch`
7. Um einen Eintrag zur Schülertabelle hinzuzufügen, geben Sie folgenden Befehl ein: `dotnet run add_student NAME VORNAME GEBDATUM KLASSE`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run add_student Mustermann Max 01.01.2010 9a`
8. Um einen Eintrag zur Kurstabelle hinzuzufügen, geben Sie folgenden Befehl ein: `dotnet run add_course FACH LEHRERNAME LEHRERVORNAME LEHRERGEBDATUM KLASSE`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run add_course Deutsch Mustermann Max 01.01.1980 9a`. Beachten Sie, dass der entsprechende Lehrer bereits in der Lehrertabelle hinterlegt sein muss.
9. Um einen Eintrag zur Tabelle der Kurstermine hinzuzufügen, geben Sie folgenden Befehl ein: `dotnet run add_coursedate KURSBEZEICHNUNG WOCHENTAG UHRZEIT`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run add_coursedate Deutsch9a Montag 10:15`. Beachten Sie, dass der entsprechende Kurs bereits in der Kurstabelle hinterlegt sein muss.
10. Um einen Eintrag zur Tabelle der Klausurnoten hinzuzufügen, geben Sie folgenden Befehl ein: `dotnet run add_examgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM PRÜFUNGSDATUM NOTE`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run add_examgrade Deutsch9a Mustermann Max 01.01.2010 01.01.2024 2,0`. Beachten Sie, dass Kurs und Schüler bereits in den entsprechenden Tabellen hinterlegt sein müssen.
11. Um einen Eintrag zur Tabelle der Mitarbeitsnoten hinzuzufügen, geben Sie folgenden Befehl ein: `dotnet run add_oralgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM NOTE`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run add_oralgrade Deutsch9a Mustermann Max 01.01.2010 2,0`. Beachten Sie, dass Kurs und Schüler bereits in den entsprechenden Tabellen hinterlegt sein müssen.
12. Um einen Eintrag aus der Lehrertabelle zu löschen, geben Sie folgenden Befehl ein: `dotnet run delete_teacher NAME VORNAME GEBDATUM`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind , also z.B. `dotnet run delete_teacher Mustermann Max 01.01.1980`. Beachten Sie, dass vorher alle Kurse gelöscht werden müssen, die dem betreffenden Lehrer zugeteilt waren.
13. Um einen Eintrag aus der Schülertabelle zu löschen, geben Sie folgenden Befehl ein: `dotnet run delete_student NAME VORNAME GEBDATUM`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run delete_student Mustermann Max 01.01.2010`. Beachten Sie, dass vorher alle Noten gelöscht werden müssen, die dem entsprechenden Schüler zugeteilt waren.
14. Um einen Eintrag aus der Kurstabelle zu löschen, geben Sie folgenden Befehl ein: `dotnet run delete_course KURSBEZEICHNUNG`, wobei das Wort in Großbuchstaben durch die Kursbezeichnung zu ersetzen ist, also z.B. `dotnet run delete_course Deutsch9a`. Beachten Sie, dass vorher alle Kurstermine des entsprechenden Kurses gelöscht werden müssen.
15. Um einen Eintrag aus der Tabelle der Kurstermine zu löschen, geben Sie folgenden Befehl ein: `dotnet run delete_coursedate KURSBEZEICHNUNG WOCHENTAG UHRZEIT`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run delete_coursedate Deutsch9a Montag 10:15`
16. Um einen Eintrag aus der Tabelle der Klausurnoten zu löschen, geben Sie folgenden Befehl ein: `dotnet run delete_examgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM PRÜFUNGSDATUM`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run delete_examgrade Deutsch9a Mustermann Max 01.01.2010 01.01.2024`
17. Um einen Eintrag aus der Tabelle der Mitarbeitsnoten zu löschen, geben Sie folgenden Befehl ein: `dotnet run delete_oralgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM`, wobei die Worte in Großbuchstaben durch die jeweiligen Attribute zu ersetzen sind, also z.B. `dotnet run delete_oralgrade Deutsch9a Mustermann Max 01.01.2010`


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

Credentials nicht hardcoden <br />
Raumbelegungen hinzufügen <br />
Kurse, die weniger als einmal die Woche stattfinden <br />
Halbjahr berücksichtigen <br />
Schüler wechselt Klasse <br />
Klassen haben natürlich nicht geschlossen die selben Kurse, jeder Schüler kann individuell Kurse besuchen <br />

