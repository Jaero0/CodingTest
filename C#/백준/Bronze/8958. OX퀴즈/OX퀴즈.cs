using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < input; i++)
        {
            string sin = Console.ReadLine();
            int sum = 0, count = 0;
            
            foreach (var c in sin)
            {
                if (c == 'O')
                {
                    count++;
                    sum += count;
                }
                else
                {
                    count = 0;
                }
            }

            sb.Append(sum + "\n");
        }

        Console.WriteLine(sb);
    }
}