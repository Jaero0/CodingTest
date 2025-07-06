string[] ss = Console.ReadLine().Split(' ');

        string f = ss[0];
        string s = ss[1];

        string tempF = f[0].ToString();
        string lastF = f[2].ToString();
        int fI = int.Parse(lastF + f[1] + tempF);
        
        string tempS = s[0].ToString();
        string lastS = s[2].ToString();
        int sI = int.Parse(lastS + s[1] + tempS);

        Console.WriteLine(fI > sI ? fI : sI);