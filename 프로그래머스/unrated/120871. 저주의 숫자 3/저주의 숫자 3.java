class Solution {
    public int solution(int n) {
        int answer = 0;

        for (int i = 0; i < n; i++) {

            answer++;

            while (true) {
                String st = String.valueOf(answer);

                if (answer % 3 == 0 || st.contains("3")) {
                    answer++;
                } else {
                    break;
                } 
            }
        }

        return answer;
    }
}