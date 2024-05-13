class Solution {
    public String solution(String s) {

        StringBuilder sb = new StringBuilder();

        char[] c = s.toCharArray();

        int count = 0;
        
        for (int i = 0; i < c.length; i++) {
            
            char c1 = c[i];

            if ('a' <= c1 && c1 <= 'z' || 'A' <= c1 && c1 <= 'Z') {

                if (count % 2 == 0) {
                    sb.append(String.valueOf(c1).toUpperCase());
                    count ++;
                } else {
                    count = 0;
                    sb.append(String.valueOf(c1).toLowerCase());
                }
            } else {
                count = 0;
                sb.append(c1);
            }
        }
        
        return sb.toString();
    }
}