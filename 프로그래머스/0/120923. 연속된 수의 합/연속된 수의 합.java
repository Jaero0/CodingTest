class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];

        int mid = total / num;
        int first = 0;

        if (num % 2 != 0) {
            first = mid - ((num-1) / 2);
        } else {
            first = mid - ((num/2) -1);
        }

        for (int i = 0; i < answer.length; i++) {

            answer[i] = first + i;
        }

        return answer;
    }
}