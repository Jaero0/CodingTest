class Solution {
	fun solution(n: Int, control: String): Int {
		var answer: Int = n

		for (i in control) {
			if (i == 'w') answer += 1
			else if (i == 's') answer -= 1
			else if (i == 'd') answer += 10
			else answer -= 10
		}

		return answer
	}
}