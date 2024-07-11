import java.io.*

fun main(args: Array<String>) {
	val br = BufferedReader(InputStreamReader(System.`in`))
	val s = br.readLine()
	
	val (a, b) = s.split(' ').map { it.toInt() }

	for (i in 1..b) {
		for (j in 1..a) {
			print("*")
		}
		println()
	}
}
