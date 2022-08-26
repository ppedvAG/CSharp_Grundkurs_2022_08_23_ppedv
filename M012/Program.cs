using System.Diagnostics;

namespace M012;

internal class Program
{
	static void Main(string[] args)
	{
		#region Einfaches Linq
		List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		int summe = 0;
		foreach (int i in list)
			summe += i;
		Console.WriteLine(summe);

		Console.WriteLine(list.Sum()); //Kurzschreibweise für Schleife darüber
		Console.WriteLine(list.Min()); //Kleinster Wert
		Console.WriteLine(list.Max()); //Größter Wert
		Console.WriteLine(list.Average()); //Durchschnitt der Liste

		Console.WriteLine(list.First()); //Erstes Element der Liste (Exception wenn kein Ergebnis)
		Console.WriteLine(list.FirstOrDefault()); //Wenn kein Ergebnis -> null

		Console.WriteLine(list.Last()); //Letztes Element der Liste (Exception wenn kein Ergebnis)
		Console.WriteLine(list.LastOrDefault()); //Wenn kein Ergebnis -> null
		#endregion

		#region Vergleich Linq Schreibweisen
		//Alle geraden Zahlen mit einer foreach-Schleife
		List<int> gerade = new();
		foreach (int i in list)
			if (i % 2 == 0)
				gerade.Add(i);

		//Standard-Linq: Alte Schreibweise (SQL ähnlich)
		List<int> geradeSQL = (from i in list 
							   where i % 2 == 0 
							   select i).ToList();

		//Methodenkette
		List<int> geradeLinq = list.Where(e => e % 2 == 0).ToList();
		#endregion

		#region Linq
		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		//Die höchste Geschwindigkeit (nur die Zahl, int)
		int maxV = fahrzeuge.Max(fzg => fzg.MaxGeschwindigkeit); //In der Klammer mit <Variablenname> => <Property> das entsprechende Feld auswählen

		//Das Fahrzeug mit der höchsten Geschwindigkeit
		Fahrzeug schnellstes = fahrzeuge.MaxBy(fzg => fzg.MaxGeschwindigkeit);

		//.Min und .MinBy existieren auch

		//Fahrzeuge nach Automarke sortieren (aufsteigend)
		List<Fahrzeug> sortiert = fahrzeuge.OrderBy(fzg => fzg.Marke).ToList();

		//Zuerst nach Marke, danach nach Geschwindigkeit sortieren (mit .ThenBy statt .OrderBy)
		List<Fahrzeug> sortiert2Mal = fahrzeuge.OrderBy(fzg => fzg.Marke).ThenBy(fzg => fzg.MaxGeschwindigkeit).ToList();

		//.OrderByDescending und .ThenByDescending -> absteigend

		//Alle Geschwindigkeiten aufsummieren (bei .Sum auswählen was summiert werden soll)
		int summeV = fahrzeuge.Sum(fzg => fzg.MaxGeschwindigkeit);

		//Aus der originalen Liste eine neue Liste erzeugen, anhand eines Felds des Objekts
		List<FahrzeugMarke> alleMarken = fahrzeuge.Select(fzg => fzg.Marke).ToList(); //Alle Marken aus der originalen Liste in eine neue Liste extrahieren

		//Distinct: Alle Einträge einzigartig machen
		List<FahrzeugMarke> alleMarkenEinzeln = alleMarken.Distinct().ToList();

		//Alle VWs aufsummieren mit mindestens 200km/h
		fahrzeuge.Where(fzg => fzg.Marke == FahrzeugMarke.VW && fzg.MaxGeschwindigkeit >= 200).Sum(fzg => fzg.MaxGeschwindigkeit); //Mehrere Funktionen miteinander verketten

		//Wie viele Audis habe ich?
		fahrzeuge.Count(fzg => fzg.Marke == FahrzeugMarke.Audi); //4

		//Fahren alle Fahrzeuge schneller als 150km/h?
		fahrzeuge.All(fzg => fzg.MaxGeschwindigkeit > 150); //Entsprechen ALLE Elemente in der Liste der Bedingung?

		//Fährt mindestens ein Fahrzeug schneller als 300km/h?
		fahrzeuge.Any(fzg => fzg.MaxGeschwindigkeit > 300); //Entspricht mindestens EIN Element in der Liste der Bedingung?

		fahrzeuge.Any(); //Überprüft, ob die Liste Elemente enthält (fahrzeuge.Count > 0)

		List<Fahrzeug[]> x = fahrzeuge.Chunk(5).ToList(); //Teilt die Liste in X große Teile auf (hier 5)
		foreach (Fahrzeug[] arr in x)
		{
			foreach (Fahrzeug f in arr)
			{
				//...
			}
		}
		#endregion

		#region Erweiterungsmethoden
		Console.WriteLine(38279.Quersumme()); //Alle ints im Projekt haben jetzt die Methode Quersumme()

		int zahl = 473;
		zahl.Quersumme();

		fahrzeuge.Shuffle();
		#endregion
	}
}

[DebuggerDisplay("Marke: {Marke}, Geschwindigkeit: {MaxGeschwindigkeit} - {typeof(Fahrzeug).FullName}")]
public class Fahrzeug
{
	public int MaxGeschwindigkeit;

	public FahrzeugMarke Marke;

	public Fahrzeug(int v, FahrzeugMarke fm)
	{
		MaxGeschwindigkeit = v;
		Marke = fm;
	}
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}