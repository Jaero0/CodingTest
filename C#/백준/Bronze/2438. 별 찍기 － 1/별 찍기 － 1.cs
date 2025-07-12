StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));


        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                sw.Write("*");
            }
            sw.WriteLine();
        }
        
        sw.Close();