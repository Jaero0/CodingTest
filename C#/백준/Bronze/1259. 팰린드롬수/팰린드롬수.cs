StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        
        while (true)
        {
            //012345 -> 012 345
            //0123456 -> 012 3 456
            string input = sr.ReadLine();

            if (input.Equals("0"))
            {
                break;
            }
            
            var l = input.Length;

            bool isDif = false;
            for (int i = 0; i < l / 2; i++)
            {
                if (input[i] != input[l -1 - i])
                {
                    isDif = true;
                    break;
                }
            }

            sw.WriteLine(isDif ? "no" : "yes");
        }

        sr.Close();
        sw.Close();