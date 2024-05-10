class Solution {
    public int solution(String t, String p) {
        int answer = 0;

        long pLong = Long.parseLong(p);
        int pLength = p.length();

        int startIndex = 0;
        while (startIndex + pLength <= t.length()) {

            String sub = t.substring(startIndex, startIndex + pLength);
            if (Long.parseLong(sub) <= pLong) {
                answer++;
            }

            startIndex++;
        }

        return answer;
    }
}