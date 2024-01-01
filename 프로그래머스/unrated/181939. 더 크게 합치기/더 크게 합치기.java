class Solution {
    public int solution(int a, int b) {

        StringBuilder sb = new StringBuilder();

        sb.append(a);
        sb.append(b);
        String f = sb.toString();

        sb.setLength(0);

        sb.append(b);
        sb.append(a);
        String s = sb.toString();

        int i1 = Integer.parseInt(f);
        int i2 = Integer.parseInt(s);
        
        return Math.max(i1, i2);
    }
}