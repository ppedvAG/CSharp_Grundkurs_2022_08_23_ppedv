#region Variablen
int zahl; //Deklaration
zahl = 5; //Zuweisung
//int: Ganze Zahl
Console.WriteLine(zahl); //zahl ausgeben

int zahlMitZuweisung = 5; //Deklaration und Zuweisung gemeinsam
Console.WriteLine(zahlMitZuweisung); //cw + Tab + Tab -> Console.WriteLine();

int zahlMalZwei = zahl * 2; //obere Zahl mal 2 = 10
Console.WriteLine(zahlMalZwei);

string wort = "Hallo"; //Text mit doppelten Hochkomma
Console.WriteLine(wort);

/*
	Mehrzeiliger
	Kommentar
*/

char zeichen = 'A'; //Einzelne Hochkomma statt doppelten
Console.WriteLine(zeichen);

double kostenDouble = 94.22; //Punkt statt Beistrich für Kommazahlen

float kostenFloat = 94.22f; //Kommazahlen standardmäßig double, Konvertierung zum float mit f am Ende

decimal kostenDecimal = 94.22m; //Geeignet für Geldwerte, Konvertierung zum decimal mit m am Ende

bool b = true; //bool: Wahr/Falschwert
b = false; //true oder false
#endregion

#region Strings
string kombination = "Das Wort ist: " + wort; //Stringverknüpfung
Console.WriteLine(kombination);

string interpolation = $"Das Wort ist {wort}"; //$-Zeichen: Stringinterpolation, Code in Strings benutzen
Console.WriteLine(interpolation);

Console.WriteLine("Umbruch \n Umbruch"); //\n für Zeilenumbruch

Console.WriteLine("Tabulator \t Tabulator");

//https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170

Console.WriteLine(@"Umbruch 
 Umbruch	Tab \n"); //Verbatimstring: Nimmt alles genau so wie es im Code getippt wurde

string pfad = "C:\\Users\\User"; //Backslash in String benutzen mit \\
Console.WriteLine(pfad);

string pfadVerbatim = @"C:\Users\User"; //Verbatimstring besonders nützlich bei Pfaden
Console.WriteLine(pfadVerbatim);
#endregion

#region Eingabe
string eingabe = Console.ReadLine(); //Console.ReadLine um eine Eingabe zu machen, Programm bleibt stehen bis Eingabe passiert, Eingabe bestätigen mit Enter
Console.WriteLine("Das Wort ist: " + eingabe); //die Eingabe benutzen

char eingabeZeichen = Console.ReadKey().KeyChar; //ReadKey um einzelnes Zeichen einzulesen, KeyChar
Console.WriteLine("Das Zeichen ist: " + eingabeZeichen);

int konvertierungInt = int.Parse(eingabe); //string zu int Konvertieren
Console.WriteLine(konvertierungInt * 5); //Jetzt kann mit der Eingabe gerechnet werden

double konvertierungDouble = double.Parse(eingabe); //Bei Eingabe aufpassen auf Kommazeichen (Beistrich bei Deutscher Kultur)
Console.WriteLine(konvertierungDouble);

int x = Convert.ToInt32(eingabe); //Convert statt int.Parse (alte Variante)
Console.WriteLine(x);
#endregion

#region Konvertierungen
//Impliziter Cast
int implizit = 50;
double implizitDouble = implizit; //int passt in double
implizitDouble += 0.5;

//Expliziter Cast
double d = 54.33;
int i = (int) d; //Konvertierung erzwingen mit (int) vor Zuweisung
float f = (float) d; //Konvertierung zu float erzwingen

Console.WriteLine(i.ToString()); //beliebige Variable zu String konvertieren
#endregion

#region Arithmetik
int zahl1 = 5;
int zahl2 = 7;
Console.WriteLine(zahl1 + zahl2); //Originale Variablen bleiben unverändert
Console.WriteLine(zahl2 % zahl1); //Rest der Division: 2

zahl1 = zahl1 + 5; //Erhöhe zahl1 um 5 und weise das Ergebnis zu
Console.WriteLine(zahl1); //10

zahl1 -= 5; //5 von zahl1 abziehen
Console.WriteLine(zahl1); //5

zahl1++; //Erhöhe Zahl um 1
zahl2--; //Verringere Zahl um 1

Math.Ceiling(4.2); //Aufrunden (5)
Math.Floor(4.2); //Abrunden (4)
Math.Round(4.5); //.5 wird auf die nächste gerade Zahl gerundet (4 statt 5)
Math.Round(5.5); //auf 6 runden

Math.Round(4.32859, 2); //Auf Zwei stellen runden mit zweitem Argument

Console.WriteLine(8 / 5); //Int-Division, da zwei Integer als Argumente
Console.WriteLine(8.0 / 5); //Kommadivision erzwingen, eine der beiden Zahlen zu einer Kommazahl konvertieren
Console.WriteLine(8f / 5);
Console.WriteLine(8d / 5); //d: Zahl zu double konvertieren (wie f und m)
Console.WriteLine((double) zahl1 / zahl2); //Variable zu double konvertieren mit (double)
#endregion