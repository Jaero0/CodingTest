class Solution {
    fun solution(a: Int, b: Int): String {
        var answer = ""


        val days = arrayOf(31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31)
        val dates = arrayOf("THU","FRI","SAT","SUN","MON","TUE","WED")

        var totalDays = 0
        for (i in 0 until a - 1) {
            totalDays += days[i]
        }
        totalDays += b

        return dates[totalDays % 7]
    }
}