class Solution {
    public String solution(String s) {

        StringBuilder sb = new StringBuilder();

        String[] arr = s.split(" ", -1);

        for (String string : arr) {

            if (string.isEmpty()) {

                sb.append(" ");
            } else {

                char[] chars = string.toCharArray();

                for (int i = 0; i < chars.length; i++) {

                    if (i % 2 == 0) {
                        sb.append(String.valueOf(chars[i]).toUpperCase());
                    } else {
                        sb.append(String.valueOf(chars[i]).toLowerCase());
                    }
                }

                sb.append(" ");
            }
        }

        sb.delete(sb.length() - 1, sb.length());

        return sb.toString();
    }
}