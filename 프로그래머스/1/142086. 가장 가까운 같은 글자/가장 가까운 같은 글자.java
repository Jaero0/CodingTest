class Solution {
    public int[] solution(String s) {
        int[] answer = new int[s.length()];

        char[] cs = s.toCharArray();

        for (int i = 0; i < cs.length; i++) {

            String check = String.valueOf(cs[i]);
            int count = 0;
            boolean isContains = false;

            for (int j = i - 1; j >= 0 ; j--) {

                String find = String.valueOf(cs[j]);
                count++;

                if (check.equals(find)) {
                    answer[i] = count;
                    cs[j] = ' ';
                    isContains = true;
                    break;
                }
            }

            if (!isContains) {
                answer[i] = -1;
            }
        }

        return answer;
    }
}