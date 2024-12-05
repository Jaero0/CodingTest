function solution(x) {
    var answer = true;

    let list = [];

    const originX = x;
    while (x > 0) {
        list.push(x % 10);
        x = Math.floor(x / 10);
    }

    let total = list.reduce((s, c) => {
        return s + c
    }, 0);
    
    console.log(originX);
    console.log(total);

    return originX % total === 0;
}