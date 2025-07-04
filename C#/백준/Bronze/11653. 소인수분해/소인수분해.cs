using System.Text;

class Program
{
    static void Main(string[] args) 
    { 
        int input = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        
        for (int i = 2; i * i <= input; i++)
        {
            while (input % i == 0)
            {
                input /= i;
                sb.Append(i + "\n");
            }
        }
        
        if(input > 1) sb.Append(input);

        Console.WriteLine(sb.ToString());
    }
}