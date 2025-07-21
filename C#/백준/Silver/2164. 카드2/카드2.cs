StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var queue = new Queue<int>();

        int c = int.Parse(sr.ReadLine());

        for (int i = 1; i <= c; i++)
        {
            queue.Enqueue(i);
        }

        while (queue.Count > 1)
        {
            queue.Dequeue();
            
            queue.Enqueue(queue.Peek());
            queue.Dequeue();
        }
        
        sw.WriteLine(queue.Peek());
        
        sr.Close();
        sw.Close();