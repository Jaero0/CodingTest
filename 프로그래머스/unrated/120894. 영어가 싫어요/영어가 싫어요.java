class Solution {
    public long solution(String numbers) {
        long answer = 0;

        String[] nums = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        String numsString = "";
        for (int i = 0; i < nums.length; i++) {

            if (numbers.contains(nums[i])) {
                numbers = numbers.replace(nums[i], String.valueOf(i));
            }
        }
        
        return Long.parseLong(numbers);
    }
}