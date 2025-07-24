StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int count = int.Parse(sr.ReadLine());

        var xyList = new List<int[]>();
        
        for (int i = 0; i < count; i++)
        {
            string[] sa = sr.ReadLine().Split(' ');
            int[] ia = new[] { int.Parse(sa[0]), int.Parse(sa[1]) };
            
            xyList.Add(ia);
        }
        
        xyList.Sort((f, s) =>
        {
            if (s[1] == f[1])
            {
                return f[0] - s[0];
            }
            return f[1] - s[1];
        });
        
        xyList.ForEach(a => sw.WriteLine($"{a[0]} {a[1]}"));
        
        sr.Close();
        sw.Close();