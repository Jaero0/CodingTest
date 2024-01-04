class Solution {
    public int[] solution(String[] keyinput, int[] board) {
        int[] answer = new int[2];

        int horizontal = 0;
        int vertical = 0;

        int boardHor = board[0] / 2;
        int boardVer = board[1] / 2;

        for (String s : keyinput) {

            if (s.equals("up") || s.equals("down")) {
                if (s.equals("up")) {
                    vertical += 1;
                } else {
                    vertical -= 1;
                }
                vertical = getInt(boardVer, vertical);
                continue;
            }

            if (s.equals("left") || s.equals("right")) {
                if (s.equals("right")) {
                    horizontal += 1;
                } else {
                    horizontal -= 1;
                }
                horizontal = getInt(boardHor, horizontal);
            }
        }

        answer[0] = horizontal;
        answer[1] = vertical;

        return answer;
    }

    public int getInt(int mainVal, int line) {
        if (line < (mainVal) * -1) {
            line = (mainVal) * -1;
        } else if (line > mainVal) {
            line = mainVal;
        }
        return line;
    }
}