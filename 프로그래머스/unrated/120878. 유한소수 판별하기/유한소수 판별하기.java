import java.util.ArrayList;
import java.util.List;

class Solution {
    public int solution(int a, int b) {
        int answer = 0;

        int min = Math.min(a, b);

        for (int i = 2; i <= min; i++) {

            if (a % i == 0 && b % i == 0) {
                a /= i;
                b /= i;
            }
        }

        List<Integer> list = new ArrayList<>();

        for (int i = 2; i <= b; i++) {

            if (b % i == 0) {
                list.add(i);
                b /= i;
                i--;
            }
        }
        
        System.out.println(list.toString());
        
        boolean isTwoOrFive = true;

        for (int i = 0; i < list.size(); i++) {

            if (list.get(i) != 2 && list.get(i) != 5) {
                isTwoOrFive = false;
                break;
            }
        }

        return isTwoOrFive ? 1 : 2;

    }
}