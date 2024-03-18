import java.util.Arrays;
import java.util.Collections;

class Solution {
    public long solution(long n) {

        Integer[] nToArr = new Integer[String.valueOf(n).length()];

        int count = 0;
        while (n > 0) {

            nToArr[count] = (int)(n % 10);
            n /= 10;
            count++;
        }

        Arrays.sort(nToArr, Collections.reverseOrder());

        StringBuilder sb = new StringBuilder();

        for (Integer i : nToArr) {
            sb.append(i);
        }

        return Long.parseLong(sb.toString());
    }
}