int[] self = new int[10999]; //9999+999+1

        self[0] = 1;

        for (int i = 1; i <= 10000; i++)
        {
            int l = i.ToString().Length;

            switch (l)
            {
                case 1:
                    self[i + i] = 1;
                    break;
                case 2:
                    int f2 = i % 10;
                    int s2 = i / 10;
                    self[i + f2 + s2] = 1;
                    break;
                case 3:
                    int f3 = i % 10;
                    int s3 = i / 10 % 10; //352 35 5
                    int t3 = i / 100;
                    self[i + f3 + s3 + t3] = 1;
                    break;
                case 4:
                    int f4 = i % 10; //3525 5
                    int s4 = i / 10 % 10; //3525 352 2
                    int t4 = i / 100 % 10; //3525 35
                    int fo4 = i / 1000;
                    self[i + f4 + s4 + t4 + fo4] = 1;
                    break;
                case 5:
                    self[10001] = 1;
                    break;
            }
        }

        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int count = 0;
        for (int i = 1; i <= 10000; i++)
        {
            if (self[i] == 0)
            {
                sw.WriteLine(i);
            }
        }
        sw.Close();