class Solution {
	fun solution(arr: IntArray): IntArray =
		if (arr.size > 1) arr.filter { it != arr.minOrNull() }.toIntArray()
		else intArrayOf(-1)
}
