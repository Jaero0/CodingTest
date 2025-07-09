int count = int.Parse(Console.ReadLine());

        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        for (int i = 0; i < count; i++)
        {
            for (int j = i; j < count - 1; j++)
            {
                sw.Write(' ');
            }

            for (int j = 0; j < i + 1; j++)
            {
                sw.Write('*');
            }
            
            sw.WriteLine();
        }
        
        sw.Close();