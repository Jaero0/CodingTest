using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] appear = new int[26];

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 26; i++)
        {
            int a = input.IndexOf((char)(i + 'a'));

            sb.Append(/*i == 25 ? a : */a + " ");
        }

        Console.WriteLine(sb.ToString());
    }
}