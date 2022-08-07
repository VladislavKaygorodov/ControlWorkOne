void FindStringOnLetterSize(string[] array, int num)
{

    int collFindString = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length == num) collFindString++;
    }
    Console.WriteLine(collFindString);
}


string[] array = new string[] { "color", "one", "table", "moskow", "two", "four" };
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Слова из скольки букв нужно выбрать из массива? ");
int findLetter = Convert.ToInt32(Console.ReadLine());


FindStringOnLetterSize(array, findLetter);

