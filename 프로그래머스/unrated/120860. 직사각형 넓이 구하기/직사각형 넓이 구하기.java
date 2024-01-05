class Solution {
    public int solution(int[][] dots) {
        int answer = 0;

        int xMin = 257;
        int xMax = -257;
        int yMin = 257;
        int yMax = -257;

        for (int i = 0; i < dots.length; i++) {

            if (xMax < dots[i][0]) {
                xMax = dots[i][0];
            }
            if (xMin > dots[i][0]) {
                xMin = dots[i][0];
            }

            if (yMax < dots[i][1]) {
                yMax = dots[i][1];
            }
            if (yMin > dots[i][1]) {
                yMin = dots[i][1];
            }
        }

        return (xMax-xMin) * (yMax - yMin);
    }
}