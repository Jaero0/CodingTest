int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

        if (inputs[0] < inputs[1] && inputs[1] < inputs[2] && inputs[2] < inputs[3] && inputs[3] < inputs[4] && inputs[4] < inputs[5] && inputs[5] < inputs[6] && inputs[6] < inputs[7])
        {
            Console.WriteLine("ascending");
        }
        else if (inputs[0] > inputs[1] && inputs[1] > inputs[2] && inputs[2] > inputs[3] && inputs[3] > inputs[4] && inputs[4] > inputs[5] && inputs[5] > inputs[6] && inputs[6] > inputs[7])
        {
            Console.WriteLine("descending");
        }
        else
        {
            Console.WriteLine("mixed");
        }