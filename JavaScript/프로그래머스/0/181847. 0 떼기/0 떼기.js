function solution(n_str) {

    const arr = [];
    let isBig = false;

    for (const e of n_str) {

        if (e > 0) {
            isBig = true;
        }

        if (isBig) {
            arr.push(e)
        }
    }

    return arr.join("");
}