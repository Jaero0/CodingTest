StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int c = int.Parse(sr.ReadLine());

        for (int i = 0; i < c; i++)
        {
            string[] s = sr.ReadLine().Split(' ');
            
            sw.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
        }
        
        sr.Close();
        sw.Close();