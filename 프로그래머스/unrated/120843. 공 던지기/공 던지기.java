import java.util.LinkedList;
import java.util.List;

class Solution {
    public int solution(int[] numbers, int k) {

        List<Integer> list =new LinkedList<>();

        int k_1 = k -1;

        if (numbers.length % 2 == 0) {

            for (int i = 1; i <= numbers.length; i++) {

                if (i % 2 != 0) {
                    list.add(i);
                }
            }

            int size = list.size();
            while (k_1 >= size) {
                k_1 -= size;
            }

            return list.get(k_1);

        } else {

            for (int i = 1; i <= numbers.length; i++) {

                if (i % 2 != 0) {
                    list.add(i);
                }
            }
            for (int i = 1; i <= numbers.length; i++) {

                if (i % 2 == 0) {
                    list.add(i);
                }
            }

            int size = list.size();
            while (k_1 >= size) {
                k_1 -= size;
            }

            return list.get(k_1);
        }
    }
}