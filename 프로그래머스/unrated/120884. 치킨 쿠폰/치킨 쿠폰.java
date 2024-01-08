class Solution {
    public int solution(int chicken) {
        int answer = 0;

        int leftCoupon = 0;
        int tmp = 0;
        while (true) {

            answer += chicken/10;
            leftCoupon += chicken % 10;

            if (leftCoupon + tmp >= 10) {

                answer += (leftCoupon + tmp) / 10;
                tmp += leftCoupon % 10;
                leftCoupon /= 10;
            }

            chicken /= 10;

            if (chicken <= 0) {
                break;
            }
        }

        return answer;
    }
}