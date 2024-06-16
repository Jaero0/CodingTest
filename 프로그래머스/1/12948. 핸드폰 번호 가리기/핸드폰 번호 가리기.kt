class Solution {
	fun solution(phone_number: String): String {
		var answer = ""

		answer = phone_number.substring(0, phone_number.length - 4).replace("[0-9]".toRegex(), "*")
		val combine = phone_number.substring(phone_number.length - 4 , phone_number.length)

		return answer + combine
	}
}
