

class Solution {
    public int solution(int n, String control) {

        char[] c = control.toCharArray();


        for (char c1 : c) {

            if (c1 == 'w') {n = n +1;}
            if (c1 == 's') {n = n -1;}
            if (c1 == 'd') {n = n +10;}
            if (c1 == 'a') {n = n -10;}
        }

        return n;
    }
}