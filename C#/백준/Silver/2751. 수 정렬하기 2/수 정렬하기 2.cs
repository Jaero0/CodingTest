StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        int gugu = int.Parse(sr.ReadLine());
        var list = new int[gugu];

        for (int i = 0; i < gugu; i++)
        {
            list[i] = int.Parse(sr.ReadLine());
        }
        
        Array.Sort(list);

        Array.ForEach(list, i => sw.WriteLine(i));
        
        sr.Close();
        sw.Close();