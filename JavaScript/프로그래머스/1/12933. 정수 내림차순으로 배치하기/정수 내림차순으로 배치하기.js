function solution(n) {
    var answer = 0;

    let list = [];

    while (n > 0) {
        list.push(n % 10);
        n /= 10;
        n = Math.floor(n)
    }

    list.sort((a, b) => {
        if (a > b) {
            return -1
        } else if (a < b) {
            return 1;
        } else {
            return 0
        }
    });
    
    return Number(list.join(''));
}