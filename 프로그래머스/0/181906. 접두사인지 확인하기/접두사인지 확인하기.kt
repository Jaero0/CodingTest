class Solution {
	fun solution(myString: String, isPrefix: String): Int {
		var answer: Int = 0

		if (myString.length >= isPrefix.length) {

			val msChars = myString.substring(0, isPrefix.length).toCharArray()

			var isIncluded = true;

			for ((index, char) in msChars.withIndex()) {

				val ipChar = isPrefix.substring(index, index + 1).toCharArray()

				if (char == ipChar[0]) {
					continue
				}
				else {
					isIncluded = false
					break
				}
			}

			return if (isIncluded) 1 else 0
		}
		else {
			return 0
		}
	}
}