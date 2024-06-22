import kotlin.math.*

class Solution {
    fun solution(left: Int, right: Int): Int {
        
        var answer = 0
        
        for(i in left..right) {
            val sqrt = sqrt(i.toDouble())
            
            answer += if(i.toDouble() % sqrt == 0.0) i * - 1 else i
        }
        
        return answer
    }
}