class Solution {
    public String[] solution(String[] quiz) {

        int len = quiz.length;
        String[] answer = new String[len];

        for (int i = 0; i < len; i++) {

            String[] quizIndArr = quiz[i].split(" ");

            int f = Integer.parseInt(quizIndArr[0]);
            int s = Integer.parseInt(quizIndArr[2]);
            
            boolean plus = true;

            if (quizIndArr[1].equals("-")) {
                plus = false;
            }
            
            int result = 0;

            if (plus) {
                result = f + s;
            } else {
                result = f - s;
            }

            if (result == Integer.parseInt(quizIndArr[4])) {
                answer[i] = "O";
            } else {
                answer[i] = "X";
            } 
        }

        return answer;
    }
}