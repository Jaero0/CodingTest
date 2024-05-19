class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;

        while (n / a != 0) {
            
            int temp = n;

            n = n / a * b;
            answer += n;
            n += temp % a;
        }

        return answer;
    }
}