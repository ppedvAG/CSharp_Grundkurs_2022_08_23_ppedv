#region Schleifen
int a = 0;
int b = 10;
while (a < b) //Schleife läuft solange Bedingung true ist
{
	Console.WriteLine("while: " + a);
	if (a == 5)
		break; //Break: beendet die Schleife
	a++;
}

//while (true) { } //Endlosschleife

int c = 0;
int d = 10;
do //wird mindestens einmal ausgeführt
{
	c++;
	if (c == 5)
		continue; //springt in den Schleifenkopf zurück
	Console.WriteLine("do-while: " + c);
}
while (c < d);

//for + Tab + Tab
for (int i = 0; i < 10; i++) //Zähler integriert
{
	Console.WriteLine("for: " + i);
}

//forr + Tab + Tab
for (int i = 10 - 1; i >= 0; i--) //Abwärts zählende Schleife
{
	Console.WriteLine("forr: " + i);
}

int[] zahlen = { 35, 346, 457, 568, 235, 268, 9, 235, 34547 };
for (int i = 0; i < zahlen.Length; i++) //Array iterieren
{
	Console.WriteLine(zahlen[i]);
}

foreach (int zahl in zahlen) //Kein daneben greifen bei Arrays möglich
{
	Console.WriteLine(zahl);
}

foreach (int zahl in zahlen) //Einzeilige Schleifen können auch ohne Klammern geschrieben werden
	Console.WriteLine(zahl);
#endregion

#region Enums
string heutigerTag = "Dienstag";
if (heutigerTag == "Dienstag ") { } //Fehleranfällig mit Strings

Wochentag heute = Wochentag.Dienstag; //Variable vom Typ Wochentag
if (heute == Wochentag.Dienstag) { } //Keine Fehleranfälligkeit

int x = 4;
Wochentag wt = (Wochentag) x; //int zu Wochentag casten
Wochentag parse = Enum.Parse<Wochentag>(Console.ReadLine()); //string oder int zu Wochentag parsen

Wochentag[] tage = Enum.GetValues<Wochentag>(); //Alle Enumwerte in ein Array einfügen
foreach (Wochentag tag in tage) //Alle Wochentage durchgehen
{
	Console.WriteLine(tag);
}
#endregion

#region Switch
int z = 4;
switch (z)
{
	case 1:
		Console.WriteLine("1");
		break;
	case 2:
		Console.WriteLine("2");
		break;
	default:
		Console.WriteLine("Andere Zahl");
		break;
}

if (heute == Wochentag.Montag) //Unpraktisch
	Console.WriteLine("Wochenanfang");
else if (heute == Wochentag.Dienstag || heute == Wochentag.Mittwoch || heute == Wochentag.Donnerstag)
	Console.WriteLine("Wochenmitte");
else if (heute == Wochentag.Freitag || heute == Wochentag.Samstag || heute == Wochentag.Sonntag)
	Console.WriteLine("Wochenende");
else
	Console.WriteLine("Fehler");

switch (heute) //Eine Variable anschauen
{
	case Wochentag.Montag: //sozusagen if Bedingung
		Console.WriteLine("Wochenanfang");
		break;
	case Wochentag.Dienstag:
	case Wochentag.Mittwoch:
	case Wochentag.Donnerstag:
		Console.WriteLine("Wochenmitte");
		break;
	case Wochentag.Freitag:
	case Wochentag.Samstag:
	case Wochentag.Sonntag:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Fehler");
		break;
}

switch (heute) //switch mit boolscher Logik
{
	//and/or statt &&/||
	case >= Wochentag.Montag and <= Wochentag.Freitag:
		Console.WriteLine("Wochentag");
		break;
	case Wochentag.Samstag or Wochentag.Sonntag:
		Console.WriteLine("Wochenende");
		break;
	//default ist optional
}
#endregion

enum Wochentag //Enumdeklaration
{
	Montag = 1, //Startindex setzen
	Dienstag,
	Mittwoch,
	Donnerstag,
	Freitag = 10, //ab hier neu zählen
	Samstag,
	Sonntag
}