class Solution {
    public String[] solution(String[] quiz) {

        int len = quiz.length;
        String[] answer = new String[len];

        for (int i = 0; i < len; i++) {

            String[] quizIndArr = quiz[i].split(" ");

            int f = Integer.parseInt(quizIndArr[0]);
            int s = Integer.parseInt(quizIndArr[2]);

            int result = f + s * (quizIndArr[1].equals("+") ? 1 : -1);

            answer[i] = result == Integer.parseInt(quizIndArr[4]) ? "O" : "X";
        }

        return answer;
    }
}