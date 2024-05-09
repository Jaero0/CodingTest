import java.util.*;

public class Solution {
    public int[] solution(int []arr) {

        List<Integer> list = new LinkedList<>();

        list.add(arr[0]);

        for(int i = 1; i<arr.length; i++) {
            if (list.get(list.size()-1) != arr[i]) {
                list.add(arr[i]);
            }
        }

        int[] ans = new int[list.size()];

        ans = list.stream().mapToInt(Integer::intValue).toArray();

        return ans;
    }
}