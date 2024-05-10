class Solution {
    public int solution(int n) {

        StringBuilder sb = new StringBuilder();

        while (n > 0) {
            sb.append(n % 3);
            n /= 3;
        }

        String string = sb.toString();
        long reverseTernary = Long.parseLong(string);

        int answer = 0;
        for (int i = 0; i < string.length(); i++) {
            answer += (int) ((reverseTernary % 10) * (int) Math.pow(3, i));
            reverseTernary /= 10;
        }

        return answer;
    }
}