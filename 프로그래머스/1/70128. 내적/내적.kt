class Solution {
	fun solution(a: IntArray, b: IntArray): Int = a.zip(b).sumOf {it.first * it.second}
}