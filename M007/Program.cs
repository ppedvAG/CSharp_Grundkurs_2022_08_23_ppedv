namespace M007;

internal class Program
{
	static void Main(string[] args)
	{
		#region GC
		for (int i = 0; i < 25; i++)
		{
			Person p = new Person(i);
		}

		GC.Collect(); //Hier GC erzwingen
		GC.WaitForPendingFinalizers(); //Warte auf alle Destruktoren
		#endregion

		#region Static
		//Statische Member müssen ohne Objekt arbeiten
		//Methode(); nicht möglich, da nicht statisch
		//new Program().Main(args); nicht möglich, da statisch
		//Program.Main(args); //statische Methoden können nur über den Klassennamen aufgerufen werden

		Console.WriteLine(Person.Zaehler); //Zaehler ist nicht auf den Objekten, sondern auf der Klasse direkt
		Person.ZaehlePerson();
		#endregion

		#region Werte/Referenztyp
		//Wertetyp
		int original = 5;
		int x = original;
		original = 10;

		//Referenztyp
		Person p1 = new Person(1);
		Person p2 = p1;
		p1.ID = 10;

		//class: Referenztyp, struct: Wertetyp
		#endregion

		#region Ref
		int anz = 0; //Für ref muss die Variable einen Startwert haben
		Addiere(3, 5, ref anz); //mit ref genauso wie bei out eine Referenz herstellen
		Addiere(3, 5, ref anz);
		Addiere(3, 5, ref anz);
		#endregion

		#region Null
		Person person = null; //null: kein Wert
		int? nullableInt = null; //int nullable machen durch int?
		bool? nullableBool = null;
		double? nullableDouble = null;
		char? nullableChar = null;

		if (person != null) //Schauen ob an der Variable ein Objekt hängt (ob das Objekt existiert)
		{

		}
		#endregion
	}

	public void Methode() { }

	public static void Addiere(int z1, int z2, ref int anzAdditionen)
	{
		anzAdditionen++; //Äußere Variable um eins erhöhen
		Console.WriteLine(z1 + z2);
	}
}