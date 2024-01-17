class Solution {
    public int solution(int[] common) {
        int answer = 0;

        int f = common[1] - common[0];
        int s = common[2] - common[1];

        boolean isGeometricSequence = true;

        if (f == s) {
            isGeometricSequence = false;
        }

        int len = common.length;
        if (isGeometricSequence) {
            int divide = common[len - 1] / common[len - 2];
            return common[len - 1] * divide;
        } else {
            int subtraction = common[len - 1] - common[len - 2];
            return common[len - 1] + subtraction;
        }
    }
}