int input = int.Parse(Console.ReadLine());
        
        StreamWriter sw = new (new BufferedStream(Console.OpenStandardOutput()));
        
        for (int i = 2; i * i <= input; i++)
        {
            while (input % i == 0)
            {
                input /= i;
                sw.WriteLine(i);
            }
        }
        
        if(input > 1) sw.Write(input);

        sw.Close(); 