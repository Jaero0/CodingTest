let numbers = require('fs')
    .readFileSync('/dev/stdin')
    .toString()
    .trim()
    .split(' ')
    .map(a => Number(a));

if (numbers[0] === numbers[1] && numbers[1] === numbers[2]) {
    console.log(10000 + numbers[0] * 1000);
} else if (
    numbers[0] === numbers[1] && numbers[0] !== numbers[2] ||
    numbers[0] === numbers[2] && numbers[0] !== numbers[1] ||
    numbers[1] === numbers[2] && numbers[1] !== numbers[0]) {
    if (numbers[0] === numbers[1]) {
        console.log(1000 + numbers[0] * 100);
    } else if (numbers[0] === numbers[2]) {
        console.log(1000 + numbers[0] * 100);
    } else {
        console.log(1000 + numbers[1] * 100)
    }
} else {
    console.log(Math.max(...numbers) * 100)
}
