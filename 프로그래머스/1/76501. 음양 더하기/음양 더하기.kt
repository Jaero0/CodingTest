class Solution {
	fun solution(absolutes: IntArray, signs: BooleanArray): Int {
		var answer: Int = 0

		for ((index,bool) in signs.withIndex()) {
			if (bool) answer += absolutes[index] else answer += absolutes[index] * -1
			
		}
		
		return answer
	}
}