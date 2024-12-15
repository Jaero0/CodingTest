function solution(n, m) {
    var answer = [];

    const gcd = getGCD(n, m);

    const lcm = n * m / gcd;

    return [gcd, lcm];
}

function getGCD(n, m) {
    if (n % m === 0) {
        return m;
    } else {
        console.log(m, n);
        return getGCD(m, n % m)
    }
}