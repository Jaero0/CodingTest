Stack<int> stack = new Stack<int>();

        int c = int.Parse(Console.ReadLine());

        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        for (int i = 0; i < c; i++)
        {
            string[] splitted = Console.ReadLine().Split(' ');
            switch (splitted[0])
            {
                case "push":
                    int sp = int.Parse(splitted[1]);
                    stack.Push(sp);
                    break;
                case "pop":
                    if (stack.Count == 0)
                    {
                        sw.WriteLine(-1);
                        continue;
                    }
                    sw.WriteLine(stack.Pop());
                    break;
                case "size":
                    sw.WriteLine(stack.Count);
                    break;
                case "empty":
                    sw.WriteLine(stack.Count > 0 ? 0 : 1);
                    break;
                case "top":
                    if (stack.TryPeek(out int a))
                    {
                        sw.WriteLine(a);
                        continue;
                    }
                    sw.WriteLine(-1);
                    break;
            }
        }
        
        sw.Close();