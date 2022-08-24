using M006.NamespaceAusserhalb; //für AndererNamespace
using System; //enthält Console
using System.Windows.Input;

namespace M006
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Namespaces
			Console.WriteLine("Hello, World!");
			//Console-Klasse: System
			//Path-Klasse: System.IO
			//Program-Klasse: M006

			Program p; //M006.Program
			NamespaceUnterhalb.Program p2; //Anderes Program explizit angeben
			NamespaceAusserhalb.Program1 p3; //Hier auch explizit angeben
			AndererNamespace.Program p4;

			ICommand command; //using System.Windows.Input erforderlich
			#endregion

			Person person = new Person(); //Neues Objekt aus dem Bauplan erstellen
			person.SetName("Max"); //Nachname setzen (mit Überprüfung)
			Console.WriteLine(person.GetName()); //Nachname auslesen

			person.Vorname = "Max"; //Properties kann man wie eine ganz normale Variable benutzen
			Console.WriteLine(person.Vorname);

			//person.Gehalt = 1000; funktioniert nicht
			if (person.Gehalt == 1000) { } //da get nicht private ist das hier möglich

			//person.Jahresgehalt = 10000; funktioniert nicht
			Console.WriteLine(person.Jahresgehalt);

			Person person1 = new Person("Max", "Mustermann"); //Konstruktor mit Parametern aufrufen

			Person person2 = new Person("Max", "Mustermann", 2000); //Verkettete Konstruktoren
			person2.PrintPerson(); //Funktion aus Person benutzen
		}
	}

	namespace NamespaceUnterhalb //M006.NamespaceUnterhalb
	{
		class Program { } //Weitere Program Klasse möglich
	}
}

namespace M006.NamespaceAusserhalb
{
	class Program1 { }
}

namespace AndererNamespace
{
	class Program 
	{
		Program1 p; //Hier using M006.NamespaceAusserhalb erforderlich
	}
}