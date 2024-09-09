import kotlin.math.min

class Solution {
    fun solution(X: String, Y: String): String {

        var mapX = ('0'..'9').associateWith { 0 }.toMutableMap()
        var mapY = ('0'..'9').associateWith { 0 }.toMutableMap()

        for (x in X) {

            mapX[x] = mapX.getValue(x) + 1
        }

        for (y in Y) {
            mapY[y] = mapY.getValue(y) + 1
        }

        val sb = StringBuilder()

        for (i in '9' downTo '0') {
            val mapxI = mapX.getValue(i)
            val mapyI = mapY.getValue(i)

            if (mapxI > 0 && mapyI > 0) {
                val min = min(mapxI, mapyI)

                for (j in 1..min) {
                    sb.append(i)
                }
            }
        }

        return if (sb.isEmpty()) {
            "-1"
        } else if (sb.toString().all { it == '0' }) {
            "0"
        } else {
            sb.toString()
        }
    }
}