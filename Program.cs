/*void FindStringOnLetterSize(string[] array, int num)
{
    int collFindString = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length == num) collFindString++;
    }
    Console.WriteLine(collFindString);
    CreateArray(collFindString);
}

void CreateArray(int size)
{
    string[] array = new string[size];
    Console.WriteLine($"[{String.Join("+", array)}]");
}

void FillArray(string[] firstArray, string[] secondArray)
{

}*/

string[] startArray = new string[] { "12", "color", "one", "9", "table", "moskow", "two", "four", "set", "1", "h", "lesson" };
Console.WriteLine($"[{String.Join(",", startArray)}]");
Console.WriteLine("Слова из скольки букв нужно выбрать из массива? ");
int findLetter = Convert.ToInt32(Console.ReadLine());

int collFindString = 0;

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length == findLetter) collFindString++;
}

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

Console.WriteLine($"[{String.Join("+", endArray)}]");