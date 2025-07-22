StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int c = int.Parse(sr.ReadLine());
        
        for (int i = 0; i < c; i++)
        {
            string s = sr.ReadLine();
            
            int openCount = 0;
            int closeCount = 0;
            bool isClosed = false;

            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    openCount++;
                }
                else
                {
                    closeCount++;
                    
                }

                if (closeCount > openCount)
                {
                    sw.WriteLine("NO");
                    isClosed = true;
                    break;
                }
            }

            if (isClosed)
            {
                continue;
            }

            sw.WriteLine(openCount - closeCount == 0 ? "YES" : "NO");
        }
        
        sr.Close();
        sw.Close();