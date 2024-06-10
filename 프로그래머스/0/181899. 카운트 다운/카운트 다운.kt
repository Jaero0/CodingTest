class Solution {
	fun solution(start: Int, end_num: Int): IntArray {
		var answer = IntArray(start - end_num + 1)

		for ((index, i) in (start downTo end_num).withIndex()) {
			answer[index] = i
		}

		return answer
	}
}