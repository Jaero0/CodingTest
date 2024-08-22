class Solution {
    fun solution(arr: IntArray, delete_list: IntArray): IntArray {
        val list = ArrayList<Int>()

        var isSelected = false
        for (i in arr) {
            for (k in delete_list) {

                if (i == k) {
                    isSelected = true
                    continue
                }
            }

            if (!isSelected) {
                list.add(i)
            }
            
            isSelected = false
        }
        
        return list.toIntArray()
    }
}