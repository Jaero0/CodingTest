import java.util.*;

class Solution {
    public int[] solution(int[] arr) {
        List<Integer> answer = new ArrayList<>();

        if (arr.length <= 1) {
            return new int[]{-1};
        }

        int min = Integer.MAX_VALUE;

        for (int i : arr) {

            if (min > i) {
                min = i;
            }
        }

        for (int j : arr) {

            if (min == j) {
                continue;
            }
            answer.add(j);
        }

        return answer.stream().mapToInt(Integer::intValue).toArray();
    }
}