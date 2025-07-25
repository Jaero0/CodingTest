StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] s = sr.ReadLine().Split(' ');

        int[] hourMin = new[] { int.Parse(s[0]), int.Parse(s[1]) };

        int leftMin = hourMin[1] - 45;

        if (leftMin < 0)
        {
            hourMin[0]--;
            hourMin[1] = 60 + leftMin;
        }
        else
        {
            hourMin[1] = leftMin;
        }

        if (hourMin[0] < 0)
        {
            hourMin[0] = 23;
        }
        
        sw.WriteLine($"{hourMin[0]} {hourMin[1]}");
        
        sr.Close();
        sw.Close();