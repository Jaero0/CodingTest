class Solution {
    public String solution(String s, int n) {

        StringBuilder sb = new StringBuilder();
        char[] cs = s.toCharArray();

        for (char c : cs) {

            if ('a' <= c && c <= 'z' || 'A' <= c && c <= 'Z') {

                if (c + n > 'z') {
                    sb.append((char)(c + n - 26));
                    continue;
                } else if (c + n > 'Z' && c <= 'Z') {
                    sb.append((char)(c + n - 26));
                    continue;
                }
                sb.append((char)(c + n));
            } else {
                sb.append(c);
            }
        }

        return sb.toString();
    }
}