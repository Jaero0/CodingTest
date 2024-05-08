

import java.util.*;

class Solution {
    public String solution(String s) {

        List<String> small = new LinkedList<>();
        List<String> big = new LinkedList<>();

        char[] chars = s.toCharArray();

        for (char c : chars) {
            if ('a' <= c && c <= 'z') {
                small.add(String.valueOf(c));
                continue;
            }
            big.add(String.valueOf(c));
        }

        sorting(small);
        sorting(big);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < small.size() + big.size(); i++) {
            if (i >= small.size()) {
                sb.append(big.get(i - small.size()));
                continue;
            }
            sb.append(small.get(i));
        }

        return sb.toString();
    }

    public void sorting(List<String> strings) {
        strings.sort(new Comparator<String>() {
            @Override
            public int compare(String o1, String o2) {
                return o2.compareTo(o1);
            }
        });
    }
}