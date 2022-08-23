#region Arrays
int[] zahlen = new int[10]; //Array mit Länge 10 (0-9)
zahlen[1] = 8; //An die Stelle 1 die Zahl 8 schreiben
Console.WriteLine(zahlen[1] * 3);

int[] zahlenDirekt = new int[] { 1, 2, 3, 4, 5 }; //Direkte Initialisierung, Länge automatisch (5)

int[] zahlenDirektKuerzer = new[] { 1, 2, 3, 4, 5 }; //Kurzschreibweise (wie oben, nur kürzer)

int[] zahlenDirektNochKuerzer = { 1, 2, 3, 4, 5 }; //Kürzeste Schreibweise

Console.WriteLine(zahlen.Length); //Größe des Arrays (5)

Console.WriteLine(zahlen.Contains(3)); //false
Console.WriteLine(zahlen.Contains(8)); //true

int[,] zweiDArray = new int[3, 3]; //Matrix (3x3), Deklaration mit Beistrich in Klammern
zweiDArray[1, 1] = 3; //Mit zwei Indizes ansprechen
Console.WriteLine(zweiDArray.Length); //Gesamte Felder: 9
Console.WriteLine(zweiDArray.Rank); //Anzahl Dimensionen: 2
Console.WriteLine(zweiDArray.GetLength(0)); //Erste Dimension Länge: 3
Console.WriteLine(zweiDArray.GetLength(1)); //Zweite Dimension Länge: 3

int[,] zweiDDirekt =
{
	{ 1, 2, 3, 4, 5 },
	{ 6, 7, 8, 9, 20 }
}; //5x2 Array automatisch

int[,,] dreiDArray = new int[4, 6, 10];
#endregion

#region Bedingungen
int zahl1 = 8;
int zahl2 = 5;

if (zahl1 == zahl2) //momentan ungleich
{
	//Wenn zahl1 gleich zahl2
	Console.WriteLine("Gleich");
}

if (zahl1 != zahl2)
{
	Console.WriteLine("Ungleich");
}

if (zahl1 < zahl2)
{
	Console.WriteLine("Zahl1 kleiner Zahl2");
}

if (zahl1 > zahl2) { }
if (zahl1 <= zahl2) { } //<= ist auch true wenn die Zahlen gleich sind
if (zahl1 >= zahl2) { }


if (zahl1 == zahl2)
{
	Console.WriteLine("Gleich");
}
else //Wenn Bedingung im if nicht wahr ist
{
	Console.WriteLine("Ungleich");
}

if (zahl1 < zahl2)
{
	Console.WriteLine("Kleiner");
}
else if (zahl1 > zahl2) //else mit Bedingung
{
	Console.WriteLine("Größer");
}
else
{
	Console.WriteLine("Gleich");
}

//if (zahl1 < zahl2)
//{
//	Console.WriteLine("Kleiner");
//}
//else //Else-If ausgeschrieben
//{
//	if (zahl1 > zahl2)
//	{
//		Console.WriteLine("Größer");
//	}
//	else
//	{
//		Console.WriteLine("Gleich");
//	}
//}

if (zahl1 == zahl2) //Klammern können bei einzeiligem Code weggelassen werden
	Console.WriteLine("Gleich");
else
	Console.WriteLine("Ungleich");

if (zahl1 < zahl2 && zahl1 > 5) //Bedingungen miteinander kombinieren mit &&, beide Bedingungen müssen wahr sein
{
	Console.WriteLine("Zahl1 kleiner Zahl2 und Zahl1 größer als 5");
}

if (zahl1 < zahl2 || zahl1 > 5) //Bedingungen kombinieren mit ||, einer der beiden muss wahr sein
{
	Console.WriteLine("Zahl1 kleiner Zahl2 oder Zahl1 größer 5");
}

bool istSonnig = false;
bool istDienstag = true;
if (!istSonnig && !istDienstag) //Bedingung invertieren mit ! vor einem bool, true wird false und false wird true
{
	Console.WriteLine("Es ist nicht sonnig");
}

if (!zahlen.Contains(3))
{
	Console.WriteLine("Zahlen enthält keine 3");
}

//if (zahl1 == zahl2)
//	Console.WriteLine("Gleich");
//else
//	Console.WriteLine("Ungleich");

//Fragezeichen Operator (?, :) ? ist if, : ist else
//Braucht immer ein else (:)
Console.WriteLine(zahl1 == zahl2 ? "Gleich" : "Ungleich");
#endregion