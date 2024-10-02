class Solution {

    private val phoneArr = arrayOf(arrayOf(1,2,3), arrayOf(4,5,6), arrayOf(7,8,9), arrayOf(10, 11, 12))

    fun solution(numbers: IntArray, hand: String): String {
        val answer = StringBuilder()

        val list = mutableListOf<String>()

        var lhPtr = Pair(3, 0)
        var rhPtr = Pair(3, 2)

        for (number in numbers.indices) {

            var num = numbers[number]
            if (num == 1 || num == 4 || num == 7) {
                answer.append("L")
                lhPtr = changePtr(num)
                continue

            } else if (num == 3 || num == 6 || num == 9) {
                answer.append("R")
                rhPtr = changePtr(num)
                continue
            }

            //2,5,8,0

            val pairLeft = getPtrValue(lhPtr)
            val pairRight = getPtrValue(rhPtr)

            var lhPtrAdd1 = pairLeft.first
            var lhCount = pairLeft.second
            var rhPtrMinus1 = pairRight.first
            var rhCount = pairRight.second

            if (num == 0) {
                num = 11
            }

            lhCount = countHandMove(lhPtrAdd1, num, lhCount)
            rhCount = countHandMove(rhPtrMinus1, num, rhCount)

            if (lhCount == rhCount) {
                val rl = hand[0].uppercase()
                answer.append(rl)

                if (rl == "R") {
                    rhPtr = changePtr(num)
                } else {
                    lhPtr = changePtr(num)
                }

            } else if (lhCount > rhCount) {
                answer.append("R")
                rhPtr = changePtr(num)

            } else {
                answer.append("L")
                lhPtr = changePtr(num)
            }
        }

        return answer.toString()
    }

    //포인터 변경
    private fun changePtr(number: Int): Pair<Int, Int> {
        val phoneArr = arrayOf(arrayOf(1,2,3), arrayOf(4,5,6), arrayOf(7,8,9), arrayOf(10, 11, 12))

        var ptr = Pair(0,0)

        if (number % 3 == 1) {
            for (i in phoneArr.indices) {
                if (phoneArr[i][0] == number) {
                    ptr = i to 0
                    break
                }
            }
        } else if (number % 3 == 2) {
            for (i in phoneArr.indices) {
                if (phoneArr[i][1] == number) {
                    ptr = i to 1
                    break
                }
            }
        } else {
            for (i in phoneArr.indices) {
                if (phoneArr[i][2] == number) {
                    ptr = i to 2
                    break
                }
            }
        }

        return ptr
    }

    //포인터에 해당되는 다이얼 가져오기
    private fun getPtrValue(ptr: Pair<Int, Int>): Pair<Int, Int> {

        var ptrVal = phoneArr[ptr.first][ptr.second]
        var count = 0

        if (ptr.second != 1) {

            if (ptrVal % 3 == 1) {
                ptrVal += 1
            } else if (ptrVal % 3 == 0) {
                ptrVal -= 1
            }
            count++
        } else {
            ptrVal = phoneArr[ptr.first][ptr.second]
        }

        return ptrVal to count
    }

    private fun countHandMove(ptr:Int, number: Int, count: Int): Int {

        var ptrCopy = ptr
        var countCopy = count

        if (ptrCopy > number) {
            while (ptrCopy > number) {
                ptrCopy -= 3
                countCopy++
            }
        } else if (ptrCopy < number) {
            while (ptrCopy < number) {
                ptrCopy += 3
                countCopy++
            }
        }

        return countCopy
    }
}