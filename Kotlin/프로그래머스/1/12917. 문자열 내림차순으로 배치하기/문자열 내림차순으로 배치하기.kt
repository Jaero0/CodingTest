class Solution {
	fun solution(s: String): String {
		var answer = ""
		
		val upper = fun1(s.filter { 'Z' >= it }.toCharArray())
		val lower = fun1(s.filter { 'Z' < it }.toCharArray())

		return answer + lower + upper
	}
	
	private fun fun1(cArr : CharArray) : String {
		
		val sb = StringBuilder()
		
		val sorted = cArr.sortedDescending()
		
		sb.append(sorted.joinToString("", transform = {it.toString()}))
		
		return sb.toString()
	}
}
