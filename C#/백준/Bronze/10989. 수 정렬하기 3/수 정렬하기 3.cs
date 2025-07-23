StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        int n = int.Parse(sr.ReadLine());
        int[] count = new int[10002];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(sr.ReadLine());
            count[num]++;
        }

        for (int i = 0; i < 10002; i++)
        {
            while (count[i] > 0)
            {
                sw.WriteLine(i);
                count[i]--;
            }
        }

        sr.Close();
        sw.Close();