class Solution {
    public String solution(int[] food) {

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i < food.length; i++) {

            int count = 0;
            while (count < food[i] / 2) {
                sb.append(i);
                count++;
            }
        }
        System.out.println(sb);

        String s1 = sb.toString();
        String s2 = sb.append(0).reverse().toString();
        
        return s1 + s2;
    }
}