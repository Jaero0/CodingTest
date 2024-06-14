class Solution {
	fun solution(n: Long): Long {
		
		return n.toString().toCharArray()
			.sortedDescending()
			.joinToString("") { i -> i.toString() }
			.toLong()
	}
}