const fs = require('fs')
let readFileSync = fs.readFileSync('/dev/stdin');

const inputt = Number(readFileSync);

if (inputt >= 90) {
    console.log('A');
} else if (inputt >= 80) {
    console.log('B');
} else if (inputt >= 70) {
    console.log('C');
} else if (inputt >= 60) {
    console.log('D');
} else {
    console.log('F')
}

