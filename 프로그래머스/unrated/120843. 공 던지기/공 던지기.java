class Solution {
    public int solution(int[] numbers, int k) {

        int resolve = (k*2-1) % numbers.length;
        return resolve == 0 ? numbers.length : resolve;
    }
}