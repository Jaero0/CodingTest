class Solution {
    public int solution(int[] absolutes, boolean[] signs) {
        
        int sum = 0;
        
        for (int i = 0; i < absolutes.length; i++) {
            
            int val = signs[i] ? absolutes[i] : absolutes[i] * -1;
            
            sum += val;
        }
        
        return sum;
    }
}