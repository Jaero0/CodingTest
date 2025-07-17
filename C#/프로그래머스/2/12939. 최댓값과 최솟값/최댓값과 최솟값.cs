public class Solution {
    public string solution(string s)
    {
        string[] split = s.Split(' ');

        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (var s1 in split)
        {
            int i = int.Parse(s1);

            if (min > i)
            {
                min = i;
            }

            if (max < i)
            {
                max = i;
            }
        }
        
        
        return $"{min} {max}";
    }
}