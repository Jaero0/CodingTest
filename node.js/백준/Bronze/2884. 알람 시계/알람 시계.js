let numbers = require('fs')
    .readFileSync('/dev/stdin')
    .toString()
    .trim()
    .split(' ')
    .map(i => Number(i));

if (numbers[1] < 45) {
    if (numbers[0] === 0) {
        numbers[0] = 23;
    } else {
        numbers[0]--
    }

    numbers[1] += 15;

    console.log(numbers[0] + " " + numbers[1]);
} else {
    console.log(numbers[0] + " " + (numbers[1] - 45))
}