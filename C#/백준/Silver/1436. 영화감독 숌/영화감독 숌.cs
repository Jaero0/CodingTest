StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int input = int.Parse(sr.ReadLine());

        if (input == 1)
        {
            sw.WriteLine(666);
            sr.Close();
            sw.Close();
            return;
        }

        int force = 666;
        int count = 1;

        while (count != input)
        {
            force++;
            if (force.ToString().Contains("666"))
            {
                count++;
            }
        }
        
        sw.WriteLine(force);
        
        sr.Close();
        sw.Close();