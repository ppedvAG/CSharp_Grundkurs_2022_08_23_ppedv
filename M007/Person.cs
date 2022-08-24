namespace M007;

internal class Person
{
	public int ID { get; set; }

	public Person(int ID)
	{
		this.ID = ID;
		ZaehlePerson();
	}

	//~ + Tab + Tab
	~Person()
	{
		Console.WriteLine($"Person eingesammelt: {ID}"); //Wird aufgerufen wenn Garbage Collector das Objekt einsammelt
	}

	#region Static
	public static int Zaehler = 0;

	public static void ZaehlePerson() => Zaehler++;
	#endregion
}
