class Solution {
	fun solution(s: String): Boolean {
		return s.toCharArray().none { it >= 'A' } && (s.length == 4 || s.length == 6)
	}
}