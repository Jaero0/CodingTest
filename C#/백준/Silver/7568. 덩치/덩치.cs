StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int input = int.Parse(sr.ReadLine());

        var heightWeight = new List<int[]>();

        for (int i = 0; i < input; i++)
        {
            int[] ints = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            
            heightWeight.Add(new []{ints[1], ints[0]});
        }


        var arr = new int[input];
        
        for (int i = 0; i < input; i++)
        {
            int h = heightWeight[i][0];
            int w = heightWeight[i][1];

            var biggerCount = 0;
            
            for (int j = 0; j < input; j++)
            {
                if (i == j)
                {
                    continue;
                };
                
                int compareH = heightWeight[j][0];
                int compareW = heightWeight[j][1];

                if (compareW > w && compareH > h) { biggerCount++; }

            }

            sw.Write(biggerCount + 1 + " ");
        }
        
        sw.Close();
        sr.Close();