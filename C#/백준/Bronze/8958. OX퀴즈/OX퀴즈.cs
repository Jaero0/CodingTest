StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        int input = int.Parse(sr.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string sin = sr.ReadLine();
            int sum = 0;
            int count = 0;
            
            foreach (var c in sin)
            {
                if (c == 'O')
                {
                    count++;
                    sum += count;
                }
                else
                {
                    count = 0;
                }
            }

            sw.WriteLine(sum);
        }
        
        sr.Close();
        sw.Close();