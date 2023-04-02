Console.Write("Введите массив данных через ',': ");
string strLine = Console.ReadLine();
string[] Array1 = strLine.Split(",");
string[] Array2 = new string[0];

for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i].Length <= 3)
    {
        Array.Resize(ref Array2, Array2.Length + 1);
        Array2[Array2.Length-1] = Array1[i];
    }

}
Console.WriteLine($"[{string.Join(",", Array1)}]=>[{string.Join(",", Array2)}]");
