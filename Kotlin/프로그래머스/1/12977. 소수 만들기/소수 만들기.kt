import kotlin.math.sqrt

class Solution {
    fun solution(nums: IntArray): Int {
        var answer = 0
        
        for (i in 0 until nums.size - 2) {
            for (j in i + 1 until nums.size) {
                for (k in j + 1 until nums.size) {

                    var count = 1
                    val sum = nums[i] + nums[j] + nums[k]
                    val sqrt = sqrt(sum.toDouble())

                    for (s in 2..sqrt.toInt()) {
                        if (sum % s == 0) {
                            count++
                        }
                    }

                    if (count == 1) {
                        answer++
                    }
                }
            }
        }

        return answer
    }
}