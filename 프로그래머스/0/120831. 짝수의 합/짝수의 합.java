class Solution {
    int answer=0;

    public int solution(int n) {
        for (int i = 0; i <= n ; i+=2) {
                answer += i;
        }
        return answer;
    }
}