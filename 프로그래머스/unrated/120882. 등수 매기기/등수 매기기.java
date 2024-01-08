import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

class Solution {
    public int[] solution(int[][] score) {

        int length = score.length;
        int[] answer = new int[length];
        List<Double> average = new ArrayList<>();

        for (int i = 0; i < length; i++) {

            int mathScore = score[i][0];
            int englishScore = score[i][1];

            average.add((mathScore + englishScore) / 2d);
        }


        List<Double> sortedAverage = new ArrayList<>();
        sortedAverage.addAll(average);
        Collections.sort(sortedAverage);
        Collections.reverse(sortedAverage);
        
        for (int i = 0; i < average.size(); i++) {

            answer[i] = sortedAverage.indexOf(average.get(i)) + 1;
        }

        return answer;
    }
}