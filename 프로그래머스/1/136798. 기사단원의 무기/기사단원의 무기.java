class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;

        for (int i = 1; i <= number; i++) {

            int count = 0;
            double sqrt = Math.sqrt(i);
            for (int j = 1; j <= sqrt; j++) {

                if (i % j == 0) {
                    count++;
                }
            }
            count = i % sqrt == 0 ? count * 2 - 1 : count * 2;

            answer += count > limit ? power : count;
        }

        return answer;
    }
}