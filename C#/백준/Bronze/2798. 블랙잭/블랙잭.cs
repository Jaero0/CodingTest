int max = int.Parse(Console.ReadLine().Split(' ')[1]);

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

        int sum = 0;
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    var num = nums[i] + nums[j] + nums[k];

                    if (num > max)
                    {
                        continue;
                    }
                    
                    if (num > sum)
                    {
                        sum = num;
                    }
                }
            }
        }

        Console.WriteLine(sum);