using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < count; i++)
        {
            string[] inp = Console.ReadLine().Split(' ');

            int repeat = int.Parse(inp[0]);

            foreach (var c in inp[1])
            {
                for (int j = 0; j < repeat; j++)
                {
                    sb.Append(c);
                }
            }

            sb.AppendLine();
        }

        Console.WriteLine(sb);
        
    }
}