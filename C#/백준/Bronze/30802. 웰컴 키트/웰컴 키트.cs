StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        int total = int.Parse(sr.ReadLine());
        string[] sizes = sr.ReadLine().Split(' ');
        
        string[] TP = sr.ReadLine().Split(' ');

        int t = int.Parse(TP[0]);
        int p = int.Parse(TP[1]);

        int tSum = 0;
        foreach (var siz in sizes)
        {
            int s = int.Parse(siz);
            int r = s / t;

            tSum += s % t != 0 ? r + 1 : r;
        }

        Console.WriteLine(tSum);
        Console.WriteLine(total / p + " " + total % p);

        sr.Close();