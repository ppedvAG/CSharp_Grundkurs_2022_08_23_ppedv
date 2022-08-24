namespace M005;

internal class Program
{
	static void Main(string[] args)
	{
		PrintAddiere(3, 6); //Funktionsaufruf über den Namen der Funktion, Parameter müssen mit angegeben werden
		PrintAddiere(3, 8);
		PrintAddiere(3, 9);
		PrintAddiere(3, 10);
		PrintAddiere(3, 11); //Code wiederverwenden

		int x = Addiere(4, 1); //Ergebnis hier weiterverwenden

		//Anhand der Parameter auswählen welche Methode verwendet wird
		double d = Addiere(4.5, 3); //Hier passt zweite Funktion

		int p = Addiere(1, 2, 3, 4, 5, 6, 7); //Hier beliebig viele Parameter möglich

		Subtrahiere(34, 2); //Hier Standardwert vom optionalen Parameter genommen (0)
		Subtrahiere(34, 2, 6); //Hier optionaler Parameter mit übergeben

		SubtrahiereOderAddiere(4, 1);
		SubtrahiereOderAddiere(4, 1, false); //Hier Verhalten der Methode ändern

		int sub;
		int add = SubtrahiereUndAddiere(4, 1, out sub); //Über das out Keyword eine Verbindung zu einer Variable herstellen, Ergebnis der Subtraktion wird in die Variable geschrieben

		Console.WriteLine(PrintWochentag(Wochentag.Mi)); //Enumwert für die Funktion verwenden

		int parse;
		if (int.TryParse("4", out parse)) //TryParse gibt einen bool zurück (hat funktioniert true/false), über out kommt der geparste int heraus
		{
			Console.WriteLine(parse);
		}
		else
		{
			Console.WriteLine("Parsen hat nicht funktioniert");
		}
		Console.WriteLine(parse); //Die parse Variable ist hier auch sichtbar


		if (int.TryParse("4", out int ergebnis)) //Variable direkt beim out in der Funktion definieren ohne extra Variable
		{
			Console.WriteLine(ergebnis);
		}
		else
		{
			Console.WriteLine("Parsen hat nicht funktioniert");
		}
		Console.WriteLine(ergebnis);
	}

	static void PrintAddiere(int z1, int z2) //Funktion mit void (kein Rückgabewert), Zwei Parameter: z1, z2
	{
		Console.WriteLine(z1 + z2);
	}

	static int Addiere(int z1, int z2) //int als Rückgabewert
	{
		return z1 + z2; //Ergebnis herausgeben
	}

	static double Addiere(double z1, double z2) //double als Rückgabewert, beliebig viele Methoden mit gleichem Namen möglich
	{
		return z1 + z2;
	}

	static double Addiere(double z1, int z2)
	{
		return z1 + z2;
	}

	static int Addiere(params int[] zahlen) //params: beliebig viele Parameter
	{
		return zahlen.Sum();
	}

	static int Subtrahiere(int z1, int z2, int z3 = 0) //z3 ist ein optionaler Parameter, muss nicht mit übergeben werden, müssen die letzten Parameter sein
	{
		return z1 - z2 - z3;
	}

	static int SubtrahiereOderAddiere(int z1, int z2, bool add = true) //bool als optionaler Parameter
	{
		//return add ? z1 + z2 : z1 - z2;
		if (add)
			return z1 + z2;
		else
			return z1 - z2;
	}

	static int SubtrahiereUndAddiere(int z1, int z2, out int sub) //out Parameter enthält Ergebnis der Subtraktion
	{
		sub = z1 - z2; //sub muss einen Wert bekommen vor return
		return z1 + z2;
	}

	static void PrintZahl(int zahl)
	{
		Console.WriteLine(zahl);
		return; //Aus Funktion herausspringen / Funktion beenden
		Console.WriteLine(zahl); //Kann nicht erreicht werden
	}

	static string PrintWochentag(Wochentag tag)
	{
		switch (tag)
		{
			case Wochentag.Mo: return "Montag"; //Bei einem switch mit return muss kein break verwendet werden
			case Wochentag.Di: return "Dienstag";
			case Wochentag.Mi: return "Mittwoch";
			case Wochentag.Do: return "Donnerstag";
			case Wochentag.Fr: return "Freitag";
			case Wochentag.Sa: return "Samstag";
			case Wochentag.So: return "Sonntag";
			default: return "Fehler"; //Es muss immer ein Wert bei einer Methode mit Rückgabewert zurückgegeben werden, daher default notwendig
		}
	}
}

public enum Wochentag
{
	Mo,
	Di,
	Mi,
	Do,
	Fr,
	Sa,
	So
}