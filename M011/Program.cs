using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace M011;

internal class Program
{
	static void Main(string[] args)
	{
		List<string> staedte = new List<string>(); //Erstellung einer Liste mit Generic (alle T im Code der Liste werden durch string ersetzt)
		staedte.Add("Hamburg"); //Elemente hinzufügen
		staedte.Add("Wien");
		staedte.Add("Köln");
		staedte.Add("Berlin");

		Console.WriteLine(staedte[1]); //Wien

		Console.WriteLine(staedte.Count); //Count statt Length, nicht Count() benutzen

		staedte[1] = "Linz"; //Zuweisungen wie beim Array auch

		staedte.Remove("Linz"); //Höhere Elemente werden aufgeschoben

		staedte.Sort(); //Liste sortieren

		foreach (string item in staedte) //Liste iterieren wie bei einem Array
		{
			Console.WriteLine(item);
		}

		///////////////////////////////////////////////////////////////////////////////////////////

		Stack<string> staedteStack = new Stack<string>();
		staedteStack.Push("Hamburg"); //Elemente hinzufügen
		staedteStack.Push("Wien");
		staedteStack.Push("Köln");
		staedteStack.Push("Berlin");

		Console.WriteLine(staedteStack.Peek()); //Oberstes Element anschauen (Berlin)

		Console.WriteLine(staedteStack.Pop()); //Oberstes Element anschauen und zurückgeben (Berlin)

		Console.WriteLine(staedteStack.Pop()); //Oberstes Element anschauen und zurückgeben (jetzt Köln)

		Queue<string> staedteQueue = new Queue<string>();
		staedteQueue.Enqueue("Hamburg"); //Elemente hinzufügen
		staedteQueue.Enqueue("Wien");
		staedteQueue.Enqueue("Köln");
		staedteQueue.Enqueue("Berlin");

		Console.WriteLine(staedteQueue.Peek()); //Erstes Element in der Schlange anschauen (Hamburg)
		Console.WriteLine(staedteQueue.Dequeue()); //Erstes Element in der Schlange anschauen und zurückgeben (Hamburg)
		Console.WriteLine(staedteQueue.Dequeue()); //Erstes Element in der Schlange anschauen und zurückgeben (jetzt Wien)

		///////////////////////////////////////////////////////////////////////////////////////////

		Dictionary<string, int> einwohnerzahlen = new(); //Dictionary: Liste von Key-Value Paaren
		einwohnerzahlen.Add("Wien", 2_000_000); //Zwei Parameter (Key und Value)
		einwohnerzahlen.Add("Berlin", 3_650_000);
		einwohnerzahlen.Add("Paris", 2_160_000);

		if (einwohnerzahlen.ContainsKey("Wien")) //Gibt es den Schlüssel im Dictionary?
			Console.WriteLine(einwohnerzahlen["Wien"]); //Value holen mit [], hier mit dem Key (string)

		einwohnerzahlen.ContainsValue(2_000_000); //Gibt es eine Stadt mit 2m Einwohnern?

		foreach (KeyValuePair<string, int> kv in einwohnerzahlen) //Dictionary durchgehen mit KeyValuePair<TKey, TValue>
		{
			Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner.");
		}

		SortedDictionary<string, int> einwohnerzahlenSorted = new(); //Sortiert sich nach jedem Add automatisch nach dem Key (Achtung Performance bei > 100000 Einträgen)
		einwohnerzahlenSorted.Add("Wien", 2_000_000); //Zwei Parameter (Key und Value)
		einwohnerzahlenSorted.Add("Berlin", 3_650_000);
		einwohnerzahlenSorted.Add("Paris", 2_160_000);

		///////////////////////////////////////////////////////////////////////////////////////////

		ObservableCollection<string> str = new(); //Benachrichtigt wenn etwas passiert
		str.CollectionChanged += Str_CollectionChanged; //Event anhängen mit +=
		str.Add("X");
		str.Add("Y");
		str.Add("Z");
		str.Remove("X");
	}

	private static void Str_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		switch (e.Action) //Was ist passiert?
		{
			case NotifyCollectionChangedAction.Add: //Wenn ein Element hinzugefügt wurde:
				Console.WriteLine($"Ein Element wurde eingefügt {e.NewItems[0]}"); //mit e.NewItems[0] auf neues Element zugreifen
				break;
			case NotifyCollectionChangedAction.Remove: //Wenn ein Element entfernt wurde:
				Console.WriteLine($"Ein Element wurde entfernt {e.OldItems[0]}");
				break;
		}
	}
}