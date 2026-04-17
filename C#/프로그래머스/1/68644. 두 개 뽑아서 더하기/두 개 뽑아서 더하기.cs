using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        var answer = new SortedSet<int>();
        
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                answer.Add(numbers[i] + numbers[j]);
            }
        }
        
        return answer.ToArray();
    }
}