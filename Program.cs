void Fillarray(string[] stringArray)
{
for (int i = 0; i < stringArray.Length; i++)
{
Console.WriteLine($"Введите {i + 1} элемент массива");
stringArray[i] = Console.ReadLine();
}
}

void printArr(string[] stringArray)
{
Console.Write("[");
for (int i = 0; i < stringArray.Length; i++)
{
Console.Write($"‘{stringArray[i]}’, ");
}
Console.Write("]");
}

string[] SymbolSize(string[] stringArray)
{
int n = 0;
for (int i = 0; i < stringArray.Length; i++)
{
if (stringArray[i].Length <= 3)
n++;
}
string[] result = new string[n];
int j = 0;
for (int i = 0; i < stringArray.Length; i++)
{
if (stringArray[i].Length <= 3)
{
result[j] = stringArray[i];
j++;
}
}
return result;
}
//-----------—
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];
Fillarray(stringArray);
printArr(SymbolSize(stringArray));