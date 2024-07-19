class Solution {
	fun solution(n: Int, m: Int): IntArray {
		var answer = IntArray(2)

		val gcd = GCD(n, m)
		
		answer[0] = gcd
		answer[1] = n * m / gcd;
		
		return answer
	}

	fun GCD(a: Int, b: Int): Int {
		return if (a % b == 0) {
			b
		} else {
			GCD(b, a%b)
		}
	}
}