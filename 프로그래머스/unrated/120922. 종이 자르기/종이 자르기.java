class Solution {
    public int solution(int M, int N) {
        int answer = 0;

        int min = Math.min(M, N);
        int max = Math.max(M, N);

        answer += min - 1;
        answer += (max - 1) * min;

        return answer;
    }
}