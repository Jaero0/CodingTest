StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        

        while (true)
        {
            string inputs = Console.ReadLine();

            if (inputs.Equals("0 0 0"))
            {
                break;
            }

            string[] splits = inputs.Split(' ');

            int[] ints = new[] { int.Parse(splits[0]), int.Parse(splits[1]), int.Parse(splits[2]) };
            
            Array.Sort(ints);

            if (ints[0] * ints[0] + ints[1] * ints[1] == ints[2] * ints[2])
            {
                sw.WriteLine("right");
            }
            else
            {
                sw.WriteLine("wrong");
            }
        }
        
        sw.Close();