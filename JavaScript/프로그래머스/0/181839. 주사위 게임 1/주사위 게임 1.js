function solution(a, b) {
    let answer = 0;

    if ((a + b) % 2 == 0) {
        if (a % 2 != 0) {
            answer += a * a + b * b;
        } else {
            answer += Math.abs(a - b);
        }
    } else {
        answer += 2 * (a + b);
    }

    return answer;
}