class Solution {
    fun solution(num_list: IntArray): Int {

        if (num_list.size > 10) {
            var x = 0
            for (i in num_list) {
                x += i
            }

            return x
        } else {
            var x = 1
            for (i in num_list) {
                x *= i
            }
            
            return x
        }
    }
}