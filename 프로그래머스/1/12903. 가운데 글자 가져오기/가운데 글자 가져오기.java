class Solution {
    public String solution(String s) {

        char[] cs = s.toCharArray();
        int length = cs.length;

        return length % 2 == 0 ? String.valueOf(cs[length / 2 - 1]) + (cs[length / 2]) : String.valueOf(cs[length / 2]);
    }
}