class Solution {
    public int solution(int n) {
        int answer = 0;

        boolean isOdd = n % 2 == 0;

        if (isOdd) {

            for (int i = 2; i <= n; i+=2) {

                answer += i*i;
            }

        } else {

            for (int i = 1; i <= n; i+=2) {

                answer += i;
            }
        }
        
        return answer;
    }
}