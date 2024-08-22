import kotlin.math.max

class Solution {
    fun solution(a: Int, b: Int): Int = max((a.toString() + b.toString()).toInt(), (b.toString() + a.toString()).toInt())
}