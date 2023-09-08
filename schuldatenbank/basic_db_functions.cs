namespace basic_functions
{
    class BasicDBHandler
    {
        void AddLehrer(string name, string vorname, string geburtsdatum, string fach1, string fach2, string fach3)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string lehrer = "'" + name + "'," + "'" + vorname + "'," + "'" + geburtsdatum + "'," + "'" + fach1 + "'," + "'" + fach2 + "'," + "'" + fach3 + "'";
            string sql_command = "INSERT INTO lehrer(name, vorname, geburtsdatum, fach1, fach2, fach3) VALUES(" + lehrer + ")";
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void AddSchüler(string name, string vorname, string geburtsdatum, string klasse)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string schüler = "'" + name + "'," + "'" + vorname + "'," + "'" + geburtsdatum + "'," + "'" + klasse + "'";
            string sql_command = "INSERT INTO schüler(name, vorname, geburtsdatum, klasse) VALUES(" + schüler + ")";
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void AddKurse(string fach, string lehrername, string lehrervorname, string lehrergebdatum, string klasse)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            kursbezeichnung = fach + klasse;
            string kurs = "'" + kursbezeichnung + "'," + "'" + fach + "'," + "'" + lehrername + "'," + "'" + lehrervorname + "'," + "'" + lehrergebdatum + "'," + "'" + klasse + "'";
            string sql_command = "INSERT INTO kurse(kursbezeichnung, fach, lehrername, lehrervorname, lehrergeburtsdatum, klasse) VALUES(" + kurs + ")";
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void AddKurstermin(string kursbezeichnung, string wochentag, string uhrzeit)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            kurstermin = "'" + kursbezeichnung + "'," + "'" + wochentag + + "'," + "'" + uhrzeit + "'";
            string sql_command = "INSERT INTO kurstermine(kursbezeichnung, wochentag, uhrzeit) VALUES(" + kurstermin + ")";
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void AddKlausurnote(string kurs, string schülername, string schülervorname, string schülergebdatum, string prüfungsdatum, string note)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string klausurnote = "'" + kurs + "'," + "'" + schülername + "'," + "'" + schülervorname + "'," + "'" + schülergebdatum + "'," + "'" + prüfungsdatum + "'," + "'" + note + "'";
            sql_command = "INSERT INTO klausurnoten (kursbezeichnung, schülername, schülervorname, schülergeburtsdatum, prüfungsdatum, note) VALUES(" + klausurnote1 + ")";
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void AddMitarbeitsnote(string kurs, string schülername, string schülervorname, string schülergebdatum, string note)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string mitarbeitsnote = "'" + kurs + "'," + "'" + schülername + "'," + "'" + schülervorname + "'," + "'" + schülergebdatum + "'," + "'" + note + "'";
            string sql_command = "INSERT INTO mitarbeitsnoten (kursbezeichnung, schülername, schülervorname, schülergeburtsdatum, note) VALUES(" + mitarbeitsnote + ")";
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void DeleteLehrer(string name, string vorname, string geburtsdatum)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string sql_command = "DELETE FROM lehrer WHERE name = " + name + " AND vorname = " + vorname + " AND geburtsdatum = " + geburtsdatum;
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void DeleteSchüler(string name, string vorname, string geburtsdatum)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string sql_command = "DELETE FROM schüler WHERE name = " + name + " AND vorname = " + vorname + " AND geburtsdatum = " + geburtsdatum;
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void DeleteKurse(string kursbezeichnung)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string sql_command = "DELETE FROM kurse WHERE kursbezeichnung = " + kursbezeichnung;
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void DeleteKurstermin(string kursbezeichnung, string wochentag, string uhrzeit)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string sql_command = "DELETE FROM kurstermine WHERE kursbezeichnung = " + kursbezeichnung + " AND wochentag = " + wochentag + " AND uhrzeit = " + uhrzeit;
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void DeleteKlausurnote(string kursbezeichnung, string schülername, string schülervorname, string schülergeburtsdatum, string prüfungsdatum)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string sql_command = "DELETE FROM klausurnoten WHERE kursbezeichnung = " + kursbezeichnung + " AND schülername = " + schülername + " AND schülervorname = " + schülervorname + " AND schülergeburtsdatum = " + schülergeburtsdatum + " AND prüfungsdatum = " + prüfungsdatum;
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
        void DeleteMitarbeitsnote(string kursbezeichnung, string schülername, string schülervorname, string schülergeburtsdatum)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=mypass;Database=schuldatenbank";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            string sql_command = "DELETE FROM mitarbeitsnoten WHERE kursbezeichnung = " + kursbezeichnung + " AND schülername = " + schülername + " AND schülervorname = " + schülervorname + " AND schülergeburtsdatum = " + schülergeburtsdatum;
            await using var command = dataSource.CreateCommand(sql_command);
            await using var reader = await command.ExecuteReaderAsync();
        };
    }
}

