StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

        int gugu = int.Parse(sr.ReadLine());
        
        
        var dict = new Dictionary<int, bool>()
        {
            {1, false}, {2, false}, {3, false}, {4, false}, {5, false}, {6, false},{7, false}, {8, false},
            {9, false}, {10, false}, {11, false}, {12, false}, {13, false}, {14, false}, {15, false}, {16, false},
            {17, false}, {18, false}, {19, false}, {20, false}
        };

        for (int i = 0; i < gugu; i++)
        {
            string[] split = sr.ReadLine().Split(' ');
            int a = 0;

            if (split.Length == 2)
            {
                a = int.Parse(split[1]);
            }

            switch (split[0])
            {
                case "add":
                    dict[a] = true;
                    break;
                case "remove":
                    dict[a] = false;
                    break;
                case "check":
                    if (dict[a] == true)
                    {
                        sw.WriteLine(1);
                        continue;
                    }
                    sw.WriteLine(0);
                    break;
                case "toggle":
                    if (dict[a] == true)
                    {
                        dict[a] = false;
                        continue;
                    }

                    dict[a] = true;
                    break;
                case "all":
                    for (int j = 1; j <= dict.Count; j++)
                    {
                        dict[j] = true;
                    }
                    
                    break;
                case "empty":
                    for (int j = 1; j <= dict.Count; j++)
                    {
                        dict[j] = false;
                    }
                    
                    break;
            }
        }
        
        sr.Close();
        sw.Close();