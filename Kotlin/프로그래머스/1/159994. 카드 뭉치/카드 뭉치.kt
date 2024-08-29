class Solution {
    fun solution(cards1: Array<String>, cards2: Array<String>, goal: Array<String>): String {
        var answer: String = ""

        val c = fun1(cards1, goal)
        val c2 = fun1(cards2, goal)

        return if (c && c2) "Yes" else "No"
    }

    fun fun1(cards: Array<String>, goal: Array<String>): Boolean {

        val cList = cards.map { goal.indexOf(it) }.toMutableList()

        var isSame = true

        val minusIndexList = mutableListOf<Int>()
        for (i in cList) {
            if (i < 0) {
                minusIndexList.add(-1)
                continue
            }
            minusIndexList.add(0)
        }

        var count = 0
        for (i in minusIndexList) {
            if (count >= 1 && i == 0) {
                isSame = false
                break
            }
            if (i < 0) {
                count++
            }
        }

        val cListSort: MutableList<Int> = mutableListOf()
        for (i in cList.size - 1 downTo 0) {
            if (cList[i] < 0) {
                cList.remove(cList[i])
                continue
            }
            cListSort.add(cList[i])
        }

        cListSort.sort()

        if (isSame) {
            for (i in cList.indices) {
                if (cList[i] != cListSort[i]) {
                    isSame = false
                    break
                }
            }
        }

        return isSame
    }
}