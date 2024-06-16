using System;

public static class LingExamp1
{
	public void Example1()
	{
        List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];

        // The query variables can also be implicitly typed by using var

        // Query #1.
        IEnumerable<int> filteringQuery =
            from num in numbers
            where num is < 3 or > 7
            select num;

        foreach (var i in filteringQuery)
            Console.WriteLine(i);
    }
}
