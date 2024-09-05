class Solution {
    fun solution(keymap: Array<String>, targets: Array<String>): IntArray {
        var answer: IntArray = IntArray(targets.size)

        val map = mutableMapOf<Char,Int>()

        // 등장 순서의 최솟값 넣어주기
        for (i in keymap.indices){
            for (j in keymap[i].indices){

                val c = keymap[i][j] //A

                map[c] = Math.min(map.getOrDefault(c, 200), j+1)//A =
            }
        }

        for (i in targets.indices) {
            var count = 0
            var isCounted = true
            
            for (c in targets[i]) {
                if (map.containsKey(c)) {
                    count += map[c]!!
                    continue
                }
                isCounted = false
            }
            answer[i] = if (!isCounted) -1 else count
        }

        return answer
    }
}