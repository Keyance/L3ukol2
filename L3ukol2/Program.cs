
using System.IO;
using System;

string cesta = @"e:\text\czechitas\text2.txt";

if (File.Exists(cesta))
{
    Console.WriteLine("soubor existuje.");
    File.WriteAllText(cesta, "");
}
else
{
    Console.WriteLine("soubor neexistuje.");
}




while (true)
{
    string text = Console.ReadLine();
    File.AppendAllText(cesta, text+Environment.NewLine);

    if (string.IsNullOrEmpty(text))
    {
        break;

    }
}

Console.WriteLine("Tady je obsah textového souboru:");
Console.WriteLine(File.ReadAllText(cesta));
Console.ReadLine();
