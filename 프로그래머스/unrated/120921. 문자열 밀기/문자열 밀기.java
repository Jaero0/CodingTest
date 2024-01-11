

import java.util.ArrayList;
import java.util.List;

class Solution {
    public int solution(String A, String B) {

        List<Character> aRightChars = new ArrayList<>();

        for (char c : A.toCharArray()) {

            aRightChars.add(c);
        }

        StringBuilder sb = new StringBuilder();
        boolean isBrokenFinished = false;
        int length = aRightChars.size();

        //right
        int rightCount = 0;

        for (int i = 0; i < length; i++) {

            for (Character aRightChar : aRightChars) {
                sb.append(aRightChar);
            }

            if (sb.toString().equals(B)) {

                isBrokenFinished = true;
                break;
            }
            sb.setLength(0);

            aRightChars.add(0, aRightChars.get(length-1));
            aRightChars.remove(length);

            rightCount++;
        }

        return !isBrokenFinished ? -1 : rightCount;
    }
}