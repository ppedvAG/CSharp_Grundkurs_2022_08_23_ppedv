namespace M013;

internal class Program
{
	static void Main(string[] args)
	{
		try //Codeblock markieren -> Rechtsklick -> Surround With -> try
		{
			string eingabe = Console.ReadLine(); //Maus über eine Methode -> Exceptions sind die Fehler die auftreten können
			int x = int.Parse(eingabe); //3 mögliche Exceptions: ArgumentNullException, FormatException, OverflowException

			if (x == 0)
				throw new TestException("Die angegebene Zahl ist 0.", "x"); //Eigene Exception werfen mit throw
		}
		catch (FormatException e) //Keine Zahl (Buchstaben)
		{
			Console.WriteLine("Keine Zahl eingegeben");
			Console.WriteLine(e.Message); //Die Nachricht der Exception (hier Input string was not in a correct format)
			Console.WriteLine(e.StackTrace); //Wo ist meine Exception im Code aufgetreten?
		}
		catch (OverflowException e) //Zahl zu klein/groß
		{
			Console.WriteLine("Zahl ist außerhalb des gültigen Bereichs");
			Console.WriteLine(e.Message);
		}
		catch (TestException e)
		{
			Console.WriteLine(e.Name);
			e.Test(); //z.B.: Datenbankverbindung schließen
			throw; //Fataler Fehler
		}
		catch (ArithmeticException e) //Fängt alle Exceptions die von ArithmeticException erben (z.B.: OverflowException, DivideByZeroException, ...
		{
			Console.WriteLine($"Ein Fehler bei einer Rechenoperation ist aufgetreten: {e.Message}");
		}
		catch (Exception e) //Alle anderen Fehler abhandeln
		{
			Console.WriteLine($"Anderer Fehler: {e.Message}");
		}
		finally //Wird immer ausgeführt, auch wenn keine Exception
		{
			Console.WriteLine("Parsen abgeschlossen");
		}
	}
}

public class TestException : Exception //Eigene Exception muss von Exception erben
{
	public string Name { get; set; }

	public TestException(string? message, string name) : base(message) => Name = name;

	public void Test() => Console.WriteLine($"TestException ist aufgetreten: {Message}");
}