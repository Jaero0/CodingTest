import java.util.*;

class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = {};

        Set<Integer> set = new HashSet<>();

        for (int i = 0; i < numbers.length - 1; i++) {

            for (int j = i + 1; j < numbers.length; j++) {

                int sum = numbers[i] + numbers[j];

                set.add(sum);
            }
        }

        return set.stream().sorted(Comparator.naturalOrder()).mapToInt(Integer::intValue).toArray();
    }
}