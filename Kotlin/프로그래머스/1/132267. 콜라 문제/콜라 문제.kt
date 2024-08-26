class Solution {
    fun solution(a: Int, b: Int, n: Int): Int {
        var answer: Int = 0

        var original = n
        var left = 0

        //2 1 20
        while (original >= a) {
            val add = original / a * b
            answer += add
            original %= a
            original += add

        }

        return answer
    }
}