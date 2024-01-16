import java.util.Arrays;

class Solution {
    public int solution(int[] array) {
        int answer = 0;

        int len = array.length;
        int[] mode = new int[1002];

        for (int j : array) {

            mode[j]++;
        }

        int max = 0;
        int maxCount = 0;

        int maxIndex = 0;
        for (int i = 0; i < mode.length; i++) {

            if (max < mode[i]) {
                max = mode[i];
                maxCount = 0;
                maxIndex = i;
            }

            if (max == mode[i]) {
                maxCount++;
            }
        }

        if (maxCount > 1) {
            return -1;
        } else {
            return maxIndex;
        }
    }
}