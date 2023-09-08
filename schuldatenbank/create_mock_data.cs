using System.Data.SqlClient;
using System.Globalization;
using Microsoft.VisualBasic;
using Npgsql;



Random random = new Random();

string[] fächer = { "Deutsch", "Mathe", "Englisch", "Chemie", "Physik", "Kunst", "Musik", "Sport", "Geographie", "Geschichte" };

string[] klassen = { "9a", "9b", "10a", "10b" };

string[] firstnames = {"John", "Mary", "James", "Jennifer", "Robert", "Susan", "Michael", "Linda", "William", "Karen", "David", "Patricia", "Richard",
    "Elizabeth", "Joseph", "Deborah", "Charles", "Barbara", "Thomas", "Jessica", "Daniel", "Sarah", "Christopher", "Nancy", "Matthew", "Lisa", "Ashley",
    "Steven", "Kimberly", "Timothy", "Angela", "Kevin", "Sandra", "Brian", "Sharon", "Mark", "Laura", "Paul", "Cynthia", "Kenneth", "Diane", "George",
    "Donna", "Ronald", "Carol", "Anthony", "Brenda", "Edward", "Pamela", "William", "Michelle", "Timothy", "Kathleen", "Nicholas", "Cheryl", "Frank", "Amy",
    "Larry", "Margaret", "Scott", "Susan", "Jeffrey", "Betty", "Brian", "Dorothy", "Andrew", "Rebecca", "Gary", "Virginia", "Peter", "Nancy", "Jonathan",
    "Deborah", "Samuel", "Sandra", "Benjamin", "Martha", "Patrick", "Ruth", "Stephen", "Amanda", "Douglas", "Janet", "Gregory", "Catherine", "Daniel",
    "Helen", "Joshua", "Marie", "Kenneth", "Kathryn", "Dennis", "Rose", "Jerry", "Jacqueline", "Terry", "Christine", "Russell", "Theresa", "Raymond"};

string[] lastnames = {"Smith", "Johnson", "Brown", "Davis", "Wilson", "Jones", "Miller", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White",
    "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez",
    "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner",
    "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy",
    "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly",
    "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores",
    "Washington", "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes", "Myers", "Ford", "Hamilton"};

string[] times = {"08:00", "09:00", "10:00", "11:00", "12:00", "14:00", "15:00"};

string[] wochentage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag" };

double[] grades = { 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75, 3.0, 3.25, 3.5, 3.75, 4.0, 4.25, 4.5, 4.75, 5.0, 5.25, 5.5, 5.75, 6.0 };



string RandomDate(int startyear, int endyear)
{
    DateTime start = new DateTime(startyear, 1, 1);
    DateTime end = new DateTime(endyear, 1, 1);
    int range = (end - start).Days;
    return start.AddDays(random.Next(range)).ToString("dd/MM/yyyy");
}


string GenerateLehrer(string[] lastnames, string[] firstnames, string[] fächer, int startyear, int endyear)
{
    int firstnamepos = random.Next(0, firstnames.Length);
    int lastnamepos = random.Next(0, lastnames.Length);
    int fach1pos = random.Next(0, fächer.Length);
    int fach2pos = random.Next(0, fächer.Length);
    int fach3pos = random.Next(0, fächer.Length);
    string my_firstname = firstnames[firstnamepos];
    string my_lastname = lastnames[lastnamepos];
    string my_date = RandomDate(startyear, endyear);
    string my_fach1 = fächer[fach1pos];
    string my_fach2 = fächer[fach2pos];
    string my_fach3 = fächer[fach3pos];
    string lehrer = "'" + my_lastname + "'," + "'" + my_firstname + "'," + "'" + my_date + "'," + "'" + my_fach1 + "'," + "'" + my_fach2 + "'," + "'" + my_fach3 + "'";
    return lehrer;
}

string GenerateSchüler(string klasse, int startyear, int endyear)
{
    int firstnamepos = random.Next(0, firstnames.Length);
    int lastnamepos = random.Next(0, lastnames.Length);
    string my_firstname = firstnames[firstnamepos];
    string my_lastname = lastnames[lastnamepos];
    string my_date = RandomDate(startyear, endyear);
    string schüler = "'" + my_lastname + "'," + "'" + my_firstname + "'," + "'" + my_date + "'," + "'" + klasse + "'";
    return schüler;
}

string GenerateKurs(string fach, string[] lehrerlastnames, string[] lehrerfirstnames, string[] lehrerbirthdates, string klasse)
{
    int pos = random.Next(0, lehrerfirstnames.Length);
    string my_firstname = lehrerfirstnames[pos];
    string my_lastname = lehrerlastnames[pos];
    string my_date = lehrerbirthdates[pos];
    string kursbezeichnung = fach + klasse;
    string kurs = "'" + kursbezeichnung + "'," + "'" + fach + "'," + "'" + my_lastname + "'," + "'" + my_firstname + "'," + "'" + my_date + "'," + "'" + klasse + "'";
    return kurs;
}

string GenerateKlausurnote(string kurs, string lastname, string firstname, string birthdate, int startyear, int endyear, double[] grades) 
{ 
    int gradepos = random.Next(0, grades.Length);
    double my_grade = grades[gradepos];
    string my_examdate = RandomDate(startyear, endyear);
    string note = "'" + kurs + "',"  + "'" + lastname + "',"  + "'" + firstname + "',"  + "'" + birthdate + "',"  + "'" + my_examdate + "'," + "'" + my_grade.ToString() + "'" ;
    return note; 
}

string GenerateMitarbeitsnote(string kurs, string lastname, string firstname, string birthdate, double[] grades) 
{ 
    int gradepos = random.Next(0, grades.Length);
    double my_grade = grades[gradepos];
    string note = "'" + kurs + "',"  + "'" + lastname + "',"  + "'" + firstname + "',"  + "'" + birthdate + "',"  + "'" + my_grade.ToString() + "'" ;
    return note; 
}


// Connect to Database
var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
await using var dataSource = NpgsqlDataSource.Create(connectionString);

// // Insert lehrer data into database
int lehrernr = 10;
for (int i = 0; i<lehrernr; i++)
{
    string lehrer = GenerateLehrer(lastnames, firstnames, fächer, 1960, 1995);
    string sql_command = "INSERT INTO lehrer(name, vorname, geburtsdatum, fach1, fach2, fach3) VALUES(" + lehrer + ")";
    await using var command = dataSource.CreateCommand(sql_command);
    await using var reader = await command.ExecuteReaderAsync();
}

// // Insert schüler data into database
int schüler_pro_klasse = 25;
for (int i = 0; i<klassen.Length; i++)
{
    for (int j = 0;j<schüler_pro_klasse;j++)
    {
        string schüler = GenerateSchüler(klassen[i],2007,2009);
        string sql_command = "INSERT INTO schüler(name, vorname, geburtsdatum, klasse) VALUES(" + schüler + ")";
        await using var command = dataSource.CreateCommand(sql_command);
        await using var reader = await command.ExecuteReaderAsync();

    }
}

// Insert Kurse into database: 1 Kurs pro Klasse und Fach

//Retrieve all lehrers from database
await using var getlehrer_command = dataSource.CreateCommand("SELECT * FROM lehrer");
await using var getlehrer_reader = await getlehrer_command.ExecuteReaderAsync();
string[] lehrerlastnames = new string[lehrernr];
string[] lehrerfirstnames = new string[lehrernr];
string[] lehrerbirthdates = new string[lehrernr];
string[] lehrerfach1 = new string[lehrernr];
string[] lehrerfach2 = new string[lehrernr];
string[] lehrerfach3 = new string[lehrernr];
int k = 0;
while (await getlehrer_reader.ReadAsync())
{
    lehrerlastnames[k] = getlehrer_reader.GetString(0);
    lehrerfirstnames[k] = getlehrer_reader.GetString(1);
    lehrerbirthdates[k] = getlehrer_reader.GetDateTime(2).ToString("dd/MM/yyyy");
    lehrerfach1[k] = getlehrer_reader.GetString(3);
    lehrerfach2[k] = getlehrer_reader.GetString(4);
    lehrerfach3[k] = getlehrer_reader.GetString(5);
    k++;
}


for (int i = 0; i < klassen.Length; i++)
{
    for (int j = 0; j < fächer.Length; j++)
    {
        // Select only lehrer that can teach the fach
        int m = 0;
        string[] suitable_lehrerlastnames = new string[lehrernr];
        string[] suitable_lehrerfirstnames = new string[lehrernr];
        string[] suitable_lehrerbirthdates = new string[lehrernr];
        for(int l = 0; l<lehrernr;l++)
        {
            if ((fächer[j] == lehrerfach1[l])|(fächer[j] == lehrerfach2[l])|fächer[j] == lehrerfach3[l])
            {
                suitable_lehrerlastnames[m] = lehrerlastnames[l];
                suitable_lehrerfirstnames[m] = lehrerfirstnames[l];
                suitable_lehrerbirthdates[m] = lehrerbirthdates[l];
                m++;
            }
        }
        // Remove Null values from arrays
        suitable_lehrerlastnames = suitable_lehrerlastnames.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        suitable_lehrerfirstnames = suitable_lehrerfirstnames.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        suitable_lehrerbirthdates= suitable_lehrerbirthdates.Where(x => !string.IsNullOrEmpty(x)).ToArray();


        string kurs = GenerateKurs(fächer[j], suitable_lehrerlastnames, suitable_lehrerfirstnames, suitable_lehrerbirthdates, klassen[i]);
        string sql_command = "INSERT INTO kurse(kursbezeichnung, fach, lehrername, lehrervorname, lehrergeburtsdatum, klasse) VALUES(" + kurs + ")";
        await using var command = dataSource.CreateCommand(sql_command);
        await using var reader = await command.ExecuteReaderAsync();
    }
}


// Insert Noten into database

// Retrieve all schüler from database
int schülernr = schüler_pro_klasse * klassen.Length;
await using var getschüler_command = dataSource.CreateCommand("SELECT * FROM schüler");
await using var getschüler_reader = await getschüler_command.ExecuteReaderAsync();
string[] schülerlastnames = new string[schülernr];
string[] schülerfirstnames = new string[schülernr];
string[] schülerbirthdates = new string[schülernr];
string[] schülerklassen = new string[schülernr];

int n = 0;
while (await getschüler_reader.ReadAsync())
{
    schülerlastnames[n] = getschüler_reader.GetString(0);
    schülerfirstnames[n] = getschüler_reader.GetString(1);
    schülerbirthdates[n] = getschüler_reader.GetDateTime(2).ToString("dd/MM/yyyy");
    schülerklassen[n] = getschüler_reader.GetString(3);
    n++;
}

// Retrieve all kurse from database
int kurse_nr = klassen.Length * fächer.Length;
await using var getkurse_command = dataSource.CreateCommand("SELECT * FROM kurse");
await using var getkurse_reader = await getkurse_command.ExecuteReaderAsync();
string[] kurse = new string[kurse_nr];
string[] kursklassen = new string[kurse_nr];

int o = 0;
while (await getkurse_reader.ReadAsync())
{
    kurse[o] = getkurse_reader.GetString(0);
    kursklassen[o] = getkurse_reader.GetString(5);
    o++;
}

// Loop through kurse, select all schüler that belong to the kurs, generate note
for(int i = 0; i < kurse_nr; i++)
{
    for(int j = 0; j < schülernr; j++)
    {
        if(schülerklassen[j] == kursklassen[i])
        {
            string mitarbeitsnote = GenerateMitarbeitsnote(kurse[i],schülerlastnames[j],schülerfirstnames[j], schülerbirthdates[j], grades);
            string klausurnote1 = GenerateKlausurnote(kurse[i],schülerlastnames[j],schülerfirstnames[j], schülerbirthdates[j], 2023, 2024, grades);
            string klausurnote2 = GenerateKlausurnote(kurse[i],schülerlastnames[j],schülerfirstnames[j], schülerbirthdates[j], 2023, 2024, grades);
            string klausurnote3 = GenerateKlausurnote(kurse[i],schülerlastnames[j],schülerfirstnames[j], schülerbirthdates[j], 2023, 2024, grades);
            string sql_command = "INSERT INTO mitarbeitsnoten (kursbezeichnung, schülername, schülervorname, schülergeburtsdatum, note) VALUES(" + mitarbeitsnote + ")";
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
            sql_command = "INSERT INTO klausurnoten (kursbezeichnung, schülername, schülervorname, schülergeburtsdatum, prüfungsdatum, note) VALUES(" + klausurnote1 + ")";
            await using var command1 = dataSource.CreateCommand(sql_command);
            await using var reader1 = await command1.ExecuteReaderAsync();
            sql_command = "INSERT INTO klausurnoten (kursbezeichnung, schülername, schülervorname, schülergeburtsdatum, prüfungsdatum, note) VALUES(" + klausurnote2 + ")";
            await using var command2 = dataSource.CreateCommand(sql_command);
            await using var reader2 = await command2.ExecuteReaderAsync();
            sql_command = "INSERT INTO klausurnoten (kursbezeichnung, schülername, schülervorname, schülergeburtsdatum, prüfungsdatum, note) VALUES(" + klausurnote3 + ")";
            await using var command3 = dataSource.CreateCommand(sql_command);
            await using var reader3 = await command3.ExecuteReaderAsync();
        }
    }
}