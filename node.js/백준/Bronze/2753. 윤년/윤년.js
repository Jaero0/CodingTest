const fs = require('fs')
let readFileSync = fs.readFileSync('/dev/stdin');

const inputt = Number(readFileSync);

if (inputt % 4 === 0 && inputt % 100 !== 0 || inputt % 400 === 0) {
    console.log('1');

} else {
    console.log('0');
}
