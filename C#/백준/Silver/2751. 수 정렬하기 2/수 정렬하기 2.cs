 StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        int gugu = int.Parse(sr.ReadLine());
        var list = new List<int>();

        for (int i = 0; i < gugu; i++)
        {
            list.Add(int.Parse(sr.ReadLine()));
        }
        
        list.Sort();

        list.ForEach(i => sw.WriteLine(i));
        sr.Close();
        sw.Close();