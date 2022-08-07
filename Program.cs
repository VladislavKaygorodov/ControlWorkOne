string[] startArray = new string[] { "12", "color", "one", "9", "table", "moskow", "two", "four", "set", "1", "h", "lesson" };
Console.WriteLine($"[{String.Join(",", startArray)}]");
Console.WriteLine("Слова из скольки букв нужно выбрать из массива? ");
int findLetter = Convert.ToInt32(Console.ReadLine());

int collFindString = 0;

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length == findLetter) collFindString++;
}

if (collFindString == 0)
{
    Console.WriteLine("Слов с искомым колличеством символов не найдено.");
}
else
{
    string[] endArray = new string[collFindString];

    int endArrayIndex = 0;

    for (int j = 0; j < startArray.Length; j++)
    {
        if (startArray[j].Length == findLetter)
        {
            endArray[endArrayIndex] = startArray[j];
            endArrayIndex++;
        }
    }

    Console.WriteLine($"[{String.Join(";", endArray)}]");
}