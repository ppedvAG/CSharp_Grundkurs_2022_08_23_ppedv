namespace M012;

internal static class ExtensionMethods //Klasse muss static sind
{
	public static int Quersumme(this int x) //mit this auf bestimmten Typen beziehen
	{
		return x.ToString().ToCharArray().Sum(e => (int) char.GetNumericValue(e));
	}

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list) //Eigene Linq Methode schreiben
	{
		return list.OrderBy(e => Random.Shared.Next());
	}
}
