import java.util.*;

class Solution {
    public int[] solution(int[] arr, int divisor) {
        
        List<Integer> divide = new ArrayList<>();
        
        for (int i : arr) {
            
            if (i % divisor == 0) {
                divide.add(i);
            } else {
                continue;
            }
        }
        
        if (divide.size() > 0) {
            
            Collections.sort(divide);
        
            return divide.stream().mapToInt(Integer::intValue).toArray();
        } else {
            int[] a = new int[]{-1};
            return a;
        }
    }
}