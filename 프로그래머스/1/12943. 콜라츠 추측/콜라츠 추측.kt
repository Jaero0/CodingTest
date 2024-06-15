class Solution {
	fun solution(num: Int): Int {
		return collatz(num.toLong(), 0)
	}

	tailrec fun collatz(num:Long, count:Int) : Int =
		when {
			count > 500 -> -1
			num == 1L -> count
			else -> collatz(if (num % 2 == 0L) num / 2 else num * 3L + 1, count + 1)
		}
	
}