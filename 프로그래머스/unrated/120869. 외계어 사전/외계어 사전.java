import java.util.ArrayList;
import java.util.List;

class Solution {
    public int solution(String[] spell, String[] dic) {
        int answer = 0;

        List<String> list = new ArrayList<>();

        int spellSize = spell.length;

        for (String string : dic) {

            String s = string;
            int count = 0;
            for (String d : spell) {

                if (s.contains(d)) {
                    s = s.replace(d, " ");
                    count++;
                }
            }

            if (count == spellSize) {
                list.add(s);
            }
        }

        return list.isEmpty() ? 2 : 1;
    }
}