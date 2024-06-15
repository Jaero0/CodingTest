class Solution {
	fun solution(num: Int): Int {
		var answer = 0

		var col = num.toLong()

		while (answer <= 501) {
			if (col == 1L) {
				break
			}
			
			if (col % 2L == 0L) {
				col /= 2L
				answer++
			} else {
				col = col * 3 + 1
				answer++
			}
		}

		return if (answer > 500) -1 else answer
	}
}