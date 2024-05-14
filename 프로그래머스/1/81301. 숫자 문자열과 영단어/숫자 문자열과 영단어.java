import java.util.*;

class Solution {
    public int solution(String s) {

        StringBuilder sb = new StringBuilder();
        StringBuilder test = new StringBuilder();

        var nums = new HashMap<String, Integer>(){{
            put("zero", 0);
            put("one", 1);
            put("two", 2);
            put("three", 3);
            put("four", 4);
            put("five", 5);
            put("six", 6);
            put("seven", 7);
            put("eight", 8);
            put("nine", 9);
        }};

        char[] cs = s.toCharArray();

        for (char c : cs) {
            
            if ('0' <= c && c <= '9') {
                sb.append(c);
                continue;
            }
            
            test.append(c);
            
            if (nums.containsKey(test.toString())) {
                sb.append(nums.get(test.toString()));
                test.setLength(0);
            }
        }

        return Integer.parseInt(sb.toString());
    }
}