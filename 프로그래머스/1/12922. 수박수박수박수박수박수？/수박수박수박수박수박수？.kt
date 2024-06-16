class Solution {
	fun solution(n: Int): String = if (n % 2 == 0) "수박".repeat(n/2) else "수박".repeat(n/2) + "수"
}