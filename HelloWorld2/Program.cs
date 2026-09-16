using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string s = Console.ReadLine();

        int v = 0, c = 0, d = 0, sp = 0;

        foreach (char x in s)
        {
            if (char.IsDigit(x)) d++;
            else if (x == ' ') sp++;
            else if (char.IsLetter(x))
            {
                char ch = char.ToLower(x);
                if ("aeiou".Contains(ch)) v++;
                else c++;
            }
        }
        Console.WriteLine("Analyzing: "+s);
        Console.WriteLine("Vowels: " + v);
        Console.WriteLine("Consonants: " + c);
        Console.WriteLine("Digits: " + d);
        Console.WriteLine("Spaces: " + sp);
    }
}