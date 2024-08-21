class Solution {
    fun solution(numbers: IntArray, n: Int): Int {
        var answer: Int = 0

        for (number in numbers) {
            
            answer += number

            if (answer > n) {
                break
            }
        }
        
        return answer
    }
}