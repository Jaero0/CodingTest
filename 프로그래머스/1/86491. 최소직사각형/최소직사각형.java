class Solution {
    public int solution(int[][] sizes) {
        int maxHoriz = 0;
        int maxVert = 0;

        for (int[] size : sizes) {
            int horiz = size[0];
            int vert = size[1];

            if (vert > horiz) {
                int temp = vert;
                vert = horiz;
                horiz = temp;
            }

            if (horiz > maxHoriz) {
                maxHoriz = horiz;
            }
            if (vert > maxVert) {
                maxVert = vert;
            }
        }

        return maxHoriz * maxVert;
    }
}