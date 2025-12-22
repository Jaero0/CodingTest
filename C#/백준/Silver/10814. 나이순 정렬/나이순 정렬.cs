public class Solution
{
    class YN
    {
        public int year;
        public string name;

        public YN(int year, string name)
        {
            this.year = year;
            this.name = name;
        }
    }
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int input = int.Parse(sr.ReadLine());
        var list = new List<KeyValuePair<int, YN>>();

        for (int i = 0; i < input; i++)
        {
            var strs = sr.ReadLine().Split(' ');
            list.Add(KeyValuePair.Create(i, new YN(int.Parse(strs[0]), strs[1])));
        }
        
        list.Sort((l1, l2) =>
        {
            int dif = l1.Value.year - l2.Value.year;

            if (dif == 0)
            {
                return l1.Key - l2.Key;
            }

            return dif;
        });
        
        list.ForEach(l => sw.WriteLine(l.Value.year + " " + l.Value.name));
        
        sw.Close();
        sr.Close();
    }
}