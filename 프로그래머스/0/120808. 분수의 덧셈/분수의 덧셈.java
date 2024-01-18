class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];

        int gcd = findGcd(denom1, denom2);
        int lcm = denom1 * denom2 / gcd;

        int firstNumer = numer1 * (lcm / denom1);
        int secondNumer = numer2 * (lcm / denom2);

        answer[0] = firstNumer + secondNumer;
        answer[1] = lcm;

        if (findGcd(answer[0], answer[1]) != 1) {
            int thisGcd = findGcd(answer[0], answer[1]);

            answer[0] /= thisGcd;
            answer[1] /= thisGcd;

            return answer;
        }
        
        return answer;
    }

    public int findGcd(int a, int b) {

        if (a % b == 0) {
            return b;
        } else {
            return findGcd(b, a % b);
        }

    }
}