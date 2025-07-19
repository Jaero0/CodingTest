StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int count = int.Parse(sr.ReadLine());
        var list = new List<int[]>();
        
        for (int i = 0; i < count; i++)
        {
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), s => int.Parse(s));

            list.Add(input);
        }
        
        list.Sort((arr, arr1) =>
        {
            if (arr[0] == arr1[0])
            {
                return arr[1] - arr1[1];
            }

            return arr[0] - arr1[0];
        });
        
        list.ForEach(arr => sw.WriteLine($"{arr[0]} {arr[1]}"));

        sr.Close();
        sw.Close();