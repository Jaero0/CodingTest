function solution(myString) {

    return myString.split('').map(c => c === 'a' || c === 'A' ? 'A' : c.toLowerCase()).join("")
}