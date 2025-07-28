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

        int force = 1665;

        for (int i = 0; i < input - 1; i++)
        {
            while (true)
            {
                if (force.ToString().Contains("666"))
                {
                    break;
                }

                force++;
            }

            if (i != input - 2)
            {
                force++;
            }
        }
        
        sw.WriteLine(force);
        
        sr.Close();
        sw.Close();