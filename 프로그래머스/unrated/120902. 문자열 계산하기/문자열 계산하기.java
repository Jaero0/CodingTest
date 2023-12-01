class Solution {
    public int solution(String my_string) {
        int answer = 0;
        
        String[] s = my_string.split(" ");

        for (int i = 0; i < s.length; i++) {
            
            if (s[i].equals("-")) {
                
                i++;
                answer -= Integer.parseInt(s[i]);
                continue;
                
            } else if (s[i].equals("+")) {
                
                i++;

            }
            
            answer += Integer.parseInt(s[i]);
        }
        
        return answer;
    }
}