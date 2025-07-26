StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var list = new List<int>();

        int[] c = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        for (int i = 1; i <= c[0]; i++)
        {
            list.Add(i);
        }
        
        sw.Write("<");

        int node = -1;

        while (true)
        {
            if (list.Count == 1)
            {
                break;
            }
            
            for (int i = 0; i < c[1]; i++)
            {
                node++;
                
                if (node >= list.Count)
                {
                    node -= list.Count;
                }
            }
            
            

            sw.Write(list[node] + ", ");

            list.RemoveAt(node);
            
            node--;
        }
        
        sw.Write(list[0]);
        
        sw.WriteLine(">");
        
        sr.Close();
        sw.Close();