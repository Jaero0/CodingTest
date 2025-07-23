StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int count = int.Parse(sr.ReadLine());

        if (count == 0)
        {
            sw.WriteLine(0);
            sr.Close();
            sw.Close();
            return;
        }
        
        var list = new List<int>();

        for (int i = 0; i < count; i++)
        {
            list.Add(int.Parse(sr.ReadLine()));
        }
        
        list.Sort();

        int rounded = (int)Math.Round(count * 0.15, MidpointRounding.AwayFromZero);

        int sum = 0;
        for (int i = rounded; i < count - rounded; i++)
        {
            sum += list[i];
        }
        
        sw.WriteLine(Math.Round((double)sum / (count - rounded * 2), MidpointRounding.AwayFromZero));
        
        sr.Close();
        sw.Close();