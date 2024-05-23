class Solution {
    public String solution(int a, int b) {
        String answer = "";

        int[] dates = new int[]{31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        String[] days = new String[]{"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};

        int totalDates = b;
        for (int i = 0; i < a - 1; i++) {
            totalDates += dates[i];
        }

        int indexDay = totalDates % 7 - 1;
        return indexDay >= 0 ? days[indexDay] : days[6];
    }
}