class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        
        int mid = total / num;

        if (num % 2 != 0) {

            int first = mid - ((num-1) / 2);

            for (int i = 0; i < answer.length; i++) {
                
                answer[i] = first;
                first++;
            }

        } else {

            int first = mid - ((num/2) -1);

            for (int i = 0; i < answer.length; i++) {

                answer[i] = first;
                first++;
            }
        }

        return answer;
    }
}