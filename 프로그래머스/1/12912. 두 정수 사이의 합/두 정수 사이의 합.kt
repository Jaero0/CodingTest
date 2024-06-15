import kotlin.math.*

class Solution {
	fun solution(a: Int, b: Int): Long = (min(a,b).toLong()..max(a,b)).sum()
}