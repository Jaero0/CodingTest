import java.util.*;

class Solution {
    public int[] solution(int[] arr) {
        int min = Integer.MAX_VALUE;
        List<Integer> answer = new ArrayList<>();

        for (int i : arr) {
            if (min > i) {
                min = i;
            }
            answer.add(i);
        }

        answer.remove(Integer.valueOf(min));
        return answer.isEmpty() ? new int[]{-1} : answer.stream().mapToInt(Integer::intValue).toArray();
    }
}