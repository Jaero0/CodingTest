class Solution {
    public String solution(String phone_number) {

        int length = phone_number.length();

        StringBuilder sb = new StringBuilder(phone_number);
        sb.replace(0, length - 4, "*".repeat(length - 4));

        return sb.toString();
    }
}