const fs = require('fs')
let readFileSync = fs.readFileSync('/dev/stdin');

console.log(readFileSync.toString().split(' ').reduce((a,c) => Number(a) + Number(c)));