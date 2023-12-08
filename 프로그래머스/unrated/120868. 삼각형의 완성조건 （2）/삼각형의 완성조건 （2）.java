import java.util.Arrays;

class Solution {
    public int solution(int[] sides) {
        int answer = 0;

        int max = Arrays.stream(sides).max().getAsInt();
        int min = Arrays.stream(sides).min().getAsInt();

        return (max + min -1) - (max - min);
    }
}