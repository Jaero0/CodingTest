function solution(n) {  
    var answer = 0;  
  
    let list = [];  
  
    while (n > 0) {  
        list.push(n % 10);  
        n = Math.floor(n / 10)  
    }  
    list.sort((a, b) => b - a);  
  
    return Number(list.join(''));  
}