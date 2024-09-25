class Solution {
    fun solution(ingredient: IntArray): Int {
        var answer: Int = 0

        val list = mutableListOf<Int>()

        for (ing in ingredient) {
            list.add(ing)

            if (list.size >= 4) {
                val size = list.size
                if (list[size - 4] == 1 &&
                    list[size - 3] == 2 &&
                    list[size - 2] == 3 &&
                    list[size - 1] == 1
                ) {
                    answer++

                    list.removeAt(size - 4)
                    list.removeAt(size - 4)
                    list.removeAt(size - 4)
                    list.removeAt(size - 4)
                }
            }
        }


        return answer
    }
}