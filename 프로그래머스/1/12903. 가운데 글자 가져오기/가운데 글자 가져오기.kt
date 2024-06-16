class Solution {
	fun solution(s: String): String = 
		s.substring(s.length / 2 - 1 + (s.length % 2) .. s.length / 2)
}
