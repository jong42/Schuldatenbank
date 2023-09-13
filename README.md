# Schuldatenbank
Dieses Projekt dient als Demonstration dafür, wie eine Lehrer- und Schülerdatenbank in C# realisiert werden kann. Das Projekt ist inspiriert durch die [LUSD](https://www.sinc.de/lusd/) Datenbank und soll dazu dienen, Schulnoten und Stundenpläne zu verwalten. Wichtige Entitäten in der Datenbank sind Lehrer, Schüler, Klassen, Kurse und Noten. Das Projekt ist nicht als fertiges Produkt zu verstehen, sondern stellt lediglich einen Prototyp dar.

## Verwendete Software
* OS: Linux Ubuntu
* psql (PostgreSQL) 14.9
* Visual Studio Code mit den Extensions C# und C# DevKit 
  
## Anleitung

### Erstellung der Datenbank
1. Geben Sie `psql -U username -a -f create_db.sql` in der Kommandozeile ein, wobei `username` durch den PostgreSQL Nutzernamen zu ersetzen ist (default: `psql -U postgres -a -f create_db.sql`)
2. Geben Sie `psql -U username -d schuldatenbank -a -f create_tables.sql` in der Kommandozeile ein, wobei `username` durch den PostgreSQL Nutzernamen zu ersetzen ist

### Kompilieren des C# Codes
3. Starten Sie ein neues Terminal in Visual Studio Code, navigieren Sie zum Repository-Ordner, und geben sie den folgenden Befehl im Terminal ein: `dotnet build`
4. Geben Sie `cd schuldatenbank` im Terminal ein
   
### Füllen der Datenbank
3. Um die Datenbank mit künstlichen Daten zu füllen, geben Sie folgenden Befehl im zuvor erstellten Terminal ein: `dotnet run fill_db`

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


## Nächste Schritte

Credentials nicht hardcoden <br />



 * Tests schreiben
 * In Docker COntainer verpacken
 * Weitere Feaures hinzufügen (Stundenpläne erstellen, Gesamtnoten berechnen)
 * Kurse individuell pro Schüler ermöglichen anstatt pro Klasse
 * ...



