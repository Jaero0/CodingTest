class Solution {
    public int solution(int[] numbers) {
        
        int zero2nine = 45;
        
        int sum = 0;
        
        for (int i : numbers) {
            sum += i;
        }
        
        return zero2nine - sum;
    }
}