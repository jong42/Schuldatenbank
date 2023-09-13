using basic_functions;
using mock_data;

string username = "postgres";
string password = "mypass";

if (args.Length > 0)
{
    if (args[0] == "fill_db")
    {
        int lehrernr = 25;
        int schülerproklasse = 25;
        MockData mymockdata = new MockData(username, password);
        mymockdata.InsertLehrer(lehrernr);
        mymockdata.InsertSchüler(schülerproklasse);
        mymockdata.InsertKurse(lehrernr);
        mymockdata.InsertNoten(schülerproklasse);
    }
    else if (args[0] == "add_teacher")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.AddLehrer(args[1], args[2], args[3], args[4], args[5], args[6]);
    }
    else if (args[0] == "add_student")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.AddSchüler(args[1], args[2], args[3], args[4]);
    }
    else if (args[0] == "add_course")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.AddKurse(args[1], args[2], args[3], args[4], args[5]);
    }
    else if (args[0] == "add_coursedate")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.AddKurstermin(args[1], args[2], args[3]);
    }
    else if (args[0] == "add_examgrade")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.AddKlausurnote(args[1], args[2], args[3], args[4], args[5], args[6]);
    }
    else if (args[0] == "add_oralgrade")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.AddMitarbeitsnote(args[1], args[2], args[3], args[4], args[5]);
    }
    else if (args[0] == "delete_teacher")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.DeleteLehrer(args[1], args[2], args[3]);
    }
    else if (args[0] == "delete_student")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.DeleteSchüler(args[1], args[2], args[3]);
    }
    else if (args[0] == "delete_course")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.DeleteKurse(args[1]);
    }
    else if (args[0] == "delete_coursedate")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.DeleteKurstermin(args[1], args[2], args[3]);
    }
    else if (args[0] == "delete_examgrade")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.DeleteKlausurnote(args[1], args[2], args[3], args[4], args[5]);
    }
    else if (args[0] == "delete_oralgrade")
    {
        BasicDBHandler mybasicdbhandler = new BasicDBHandler(username, password);
        mybasicdbhandler.DeleteMitarbeitsnote(args[1], args[2], args[3], args[4]);
    }

    else
    {
        Console.WriteLine("Unkown command line argument: " + args[0]);
        Console.WriteLine("Valid arguments are:");
        Console.WriteLine("fill_db");
        Console.WriteLine("add_teacher NAME VORNAME GEBDATUM FACH1 FACH2 FACH3");
        Console.WriteLine("add_student NAME VORNAME GEBDATUM KLASSE");
        Console.WriteLine("add_course FACH LEHRERNAME LEHRERVORNAME LEHRERGEBDATUM KLASSE");
        Console.WriteLine("add_coursedate KURSBEZEICHNUNG WOCHENTAG UHRZEIT");
        Console.WriteLine("add_examgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM PRÜFUNGSDATUM NOTE");
        Console.WriteLine("add_oralgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM NOTE");
        Console.WriteLine("delete_teacher NAME VORNAME GEBDATUM");
        Console.WriteLine("delete_student NAME VORNAME GEBDATUM");
        Console.WriteLine("delete_course KURSBEZEICHNUNG");
        Console.WriteLine("delete_coursedate KURSBEZEICHNUNG WOCHENTAG UHRZEIT");
        Console.WriteLine("delete_examgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM PRÜFUNGSDATUM");
        Console.WriteLine("delete_oralgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM");
    }
}
else
{
    Console.WriteLine("Please provide one of the following command line arguments to interact with the database:");
    Console.WriteLine("fill_db");
    Console.WriteLine("add_teacher NAME VORNAME GEBDATUM FACH1 FACH2 FACH3");
    Console.WriteLine("add_student NAME VORNAME GEBDATUM KLASSE");
    Console.WriteLine("add_course FACH LEHRERNAME LEHRERVORNAME LEHRERGEBDATUM KLASSE");
    Console.WriteLine("add_coursedate KURSBEZEICHNUNG WOCHENTAG UHRZEIT");
    Console.WriteLine("add_examgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM PRÜFUNGSDATUM NOTE");
    Console.WriteLine("add_oralgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM NOTE");
    Console.WriteLine("delete_teacher NAME VORNAME GEBDATUM");
    Console.WriteLine("delete_student NAME VORNAME GEBDATUM");
    Console.WriteLine("delete_course KURSBEZEICHNUNG");
    Console.WriteLine("delete_coursedate KURSBEZEICHNUNG WOCHENTAG UHRZEIT");
    Console.WriteLine("delete_examgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM PRÜFUNGSDATUM");
    Console.WriteLine("delete_oralgrade KURSBEZEICHNUNG SCHÜLERNAME SCHÜLERVORNAME SCHÜLERGEBDATUM");
}