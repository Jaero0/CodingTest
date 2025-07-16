StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = sr.ReadLine();
        while (!input.Equals("0"))
        {
            //012345 -> 012 345
            //0123456 -> 012 3 456
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

            input = sr.ReadLine();
        }

        sr.Close();
        sw.Close();