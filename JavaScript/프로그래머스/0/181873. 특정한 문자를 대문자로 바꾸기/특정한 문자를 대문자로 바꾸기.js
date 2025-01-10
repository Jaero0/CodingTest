function solution(my_string, alp) {

    const arr = []
    const capitalAlp = alp.toUpperCase()
    my_string.split('').forEach(c => c === alp ? arr.push(capitalAlp) : arr.push(c))

    return arr.join("")
}