import java.util.*;

class Solution {
    public int[] solution(int[] array, int[][] commands) {

        int[] answer = new int[commands.length];

        for (int i = 0; i < commands.length; i++) {

            int[] indexOfCommands = commands[i];
            List<Integer> list = new ArrayList<>();

            for (int j = indexOfCommands[0] - 1; j < indexOfCommands[1]; j++) {

                list.add(array[j]);
            }

            list.sort(Comparator.naturalOrder());

            answer[i] = list.get(indexOfCommands[2] - 1);
        }
        return answer;
    }
}