StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int c = int.Parse(sr.ReadLine());
        var q = new Queue<int>();

        for (int i = 0; i < c; i++)
        {
            string[] ss = sr.ReadLine().Split(' ');

            switch (ss[0])
            {
                case "push": 
                    q.Enqueue(int.Parse(ss[1]));
                    break;
                case "pop":
                    sw.WriteLine(q.Count == 0 ? -1 : q.Dequeue());
                    break;
                case "size":
                    sw.WriteLine(q.Count);
                    break;
                case "empty":
                    sw.WriteLine(q.Count == 0 ? 1 : 0);
                    break;
                case "front":
                    sw.WriteLine(q.Count == 0 ? -1 : q.Peek());
                    break;
                case "back":
                    sw.WriteLine(q.Count == 0 ? -1 : q.ToArray()[q.Count - 1]);
                    break;
            }
        }
        
        
        sr.Close();
        sw.Close();