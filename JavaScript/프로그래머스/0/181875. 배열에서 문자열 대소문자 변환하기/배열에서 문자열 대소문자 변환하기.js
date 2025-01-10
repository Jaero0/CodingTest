function solution(strArr) {

    return strArr.map(s => strArr.indexOf(s) % 2 === 0 ? s.toLowerCase() : s.toUpperCase())
}