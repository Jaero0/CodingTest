import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

class Solution {
    public int[] solution(int[] numlist, int n) {
        int length =numlist.length;

        int[] answer = new int[length];

        List<String> list = new ArrayList<>();

        for (int i : numlist) {

            if (i <= n) {
                list.add(String.valueOf(n - i) + "!");
            } else {
                list.add(String.valueOf(i - n));
            }
        }

        list.sort(Comparator.comparingInt(Solution::extractNumber).thenComparing(Solution::endsWithExclamation));

        for (int i = 0; i < length; i++) {

            if (list.get(i).contains("!")) {
                String put = list.get(i).replace("!", "");
                answer[i] = n - Integer.parseInt(put) ;
            } else {
                String put = list.get(i);
                answer[i] = n + Integer.parseInt(put);
            }
        }

        return answer;
    }

    private static int extractNumber(String s) {
        // 마지막 문자가 '!'인 경우 느낌표를 제외하고 숫자로 변환
        if (s.endsWith("!")) {
            s = s.substring(0, s.length() - 1);
        }
        return Integer.parseInt(s);
    }

    // 문자열이 '!'로 끝나는지 여부를 반환하는 메서드
    private static int endsWithExclamation(String s) {
        return s.endsWith("!") ? 1 : 0;
    }
}