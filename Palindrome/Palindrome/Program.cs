using System.Diagnostics.Tracing;

internal class Program
{
    private static void Main(string[] args)
    {
        string word = "radar";
        int i = 0;
        int j = word.Length - 1;
        for (; i < j;)
        {
            if (word[i] == word[j])
            {
                i++;
                j--;
            }
            else
            {
                break;
            }
        }
        if (i > j || i == j)
        {
            Console.WriteLine("Is a palindrome");
        }
        else
        {
            Console.WriteLine("Is not a palindrome");
        }
    }
}