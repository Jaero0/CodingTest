int count = int.Parse(Console.ReadLine());

        int[,] floorRoom = new int[15, 15];

        for (int i = 0; i < 15; i++)
        {
            floorRoom[i, 1] = 1;
            floorRoom[0, i] = i;
        }
        
        for (int i = 1; i < 15; i++)
        {
            for (int j = 2; j < 15; j++)
            {
                floorRoom[i,j] = floorRoom[i, j - 1] + floorRoom[i - 1, j];
            }
        }
        
        for (int i = 0; i < count; i++)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine(floorRoom[floor,room]);
        }