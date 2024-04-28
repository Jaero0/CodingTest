class Solution {
    public boolean solution(int x) {
        
        int sum = 0;
        int copyX = x;
        
        while(x > 0) {
            sum += x % 10;
            x /= 10;
            
            System.out.println(sum);
        }
        
        return copyX % sum == 0 ? true : false;
    }
}