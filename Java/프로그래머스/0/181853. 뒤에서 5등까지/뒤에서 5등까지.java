import java.util.*;
import java.util.stream.*;

class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[5];

        List<Integer> list = 
                Arrays.stream(num_list)
                .boxed()
                .sorted(Comparator.naturalOrder())
                .collect(Collectors.toList());

        for (int i = 0; i < answer.length; i++) {
            answer[i] = list.get(i);
        }
        
        return answer;
    }
}