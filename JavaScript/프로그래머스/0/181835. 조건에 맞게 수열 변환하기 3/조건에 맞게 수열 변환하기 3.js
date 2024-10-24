function solution(arr, k) {
    let answer = [];

    if (k % 2 == 0) {
        arr.forEach((el, ind) => answer[ind] = el + k);
    } else {
        arr.forEach((el, ind) => answer[ind] = el * k);
    }
    

    return answer;
}