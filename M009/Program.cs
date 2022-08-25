namespace M009;

internal class Program
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch("Max", 23); //Variablentyp Mensch, kann alle Objekte halten die vom Typ Mensch oder darunter in der Vererbungshierarchie sind
		Lebewesen lw = new Mensch("Max", 23); //Variablentyp Lebewesen, kann alle Objekte halten die vom Typ Lebewesen oder darunter in der Vererbungshierarchie sind
		object o = new Mensch("Max", 23); //object: Basisklasse aller Klassen in C#

		Console.WriteLine(m.GetType().Name); //Mensch
		Console.WriteLine(lw.GetType().Name); //Mensch
		Console.WriteLine(o.GetType().Name); //Mensch
		//Alle Typen sind Mensch, da alle Objekte Mensch sind

		Type tm = typeof(Mensch);
		Type tlw = typeof(Lebewesen);
		Type to = typeof(Object);

		Console.WriteLine(tm.Name); //Mensch
		Console.WriteLine(tlw.Name); //Lebewesen
		Console.WriteLine(to.Name); //Object
		//Gibt den Typen über einen Klassennamen aus

		#region Exakter Typvergleich
		if (m.GetType() == typeof(Mensch))
		{
			//ist mein Objekt ein Mensch?
		}

		if (m.GetType() == typeof(Lebewesen)) //Exakter Typvergleich
		{
			//Keine Übereinstimmung
		}
		#endregion

		#region Vererbungshierarchie Typvergleich
		if (lw is Mensch)
		{
			//Das Objekt ist mit Mensch kompatibel
		}

		if (lw is Lebewesen)
		{
			//Das Objekt ist auch mit Lebewesen kompatibel
		}

		if (lw is object)
		{
			//Das Objekt ist auch mit Object kompatibel
		}
		#endregion

		#region Virtual Override
		Mensch mensch = new Mensch("Max", 33);
		mensch.WasBinIch(); //Ich bin ein Mensch, mein Name ist Max und bin 33 Jahre alt (Methode von Mensch)

		Lebewesen l = mensch;
		l.WasBinIch(); //Ich bin ein Mensch, mein Name ist Max und bin 33 Jahre alt (Methode von Mensch)
		#endregion

		#region New
		Mensch mensch2 = new Mensch("Max", 23);
		mensch2.WasBinIch(); //Ich bin ein Mensch und bin 23 Jahre alt (Methode von Mensch)

		Lebewesen l2 = mensch2;
		l2.WasBinIch(); //Ich bin ein Lebewesen (Methode von Lebewesen)
		#endregion

		//new Lebewesen(); nicht möglich

		Lebewesen[] array = new Lebewesen[3]; //Array von Lebenwesen
		array[0] = new Mensch("Max", 23); //Alle Klassen die von Lebewesen erben können hinzugefügt werden
		array[1] = new Hund("Bello");
		array[2] = new Mensch("Max", 34);

		foreach (Lebewesen a in array)
		{
			if (a.GetType() == typeof(Mensch))
			{
				//Mach etwas was nur für Menschen funktioniert
				Mensch x = (Mensch) a;
				x.MenschMethode();
			}

			if (a.GetType() == typeof(Hund))
			{
				//Mach etwas was nur für Hunde funktioniert
				Hund x = (Hund) a;
				x.HundMethode();
			}
		}
	}
}