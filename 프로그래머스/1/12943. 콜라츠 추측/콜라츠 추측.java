class Solution {
    public int solution(int num) {
        
        int count = 0;
        
        long copyNum = (long) num;
        
        while(copyNum > 1) {
            
            copyNum = copyNum % 2 == 0 ? copyNum / 2 : copyNum * 3 + 1;
            count++;
            
            if (count > 500) {
                break;
            }
        }
        
        return count == 0 ? 0 : count > 500 ? -1 : count;
    }
}