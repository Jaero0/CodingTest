StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int gugu = int.Parse(Console.ReadLine());

            for (int j = 1; j <= 9; j++)
            {
                sw.WriteLine($"{gugu} * {j} = {gugu * j}");
            }
        
        sw.Close();