function solution(array) {
    var answer = 0;

    let maxVal = Math.max(...array); 2

    //maxVal + 1개의 index를 가진 배열을 선언후 fill로 모든 인덱스를 0으로 채움
    const countArr = new Array(maxVal + 1).fill(0);

    for (let i = 0; i < array.length; i++) {
        const ind = array[i];

        countArr[ind] ++;
    }

    

    let maxCount = 0;
    maxVal = 0;
    for (const i of countArr) {

        if (i === maxVal) {
            maxCount++;
            continue
        }

        if (i > maxVal) {
            maxVal = i;
            maxCount = 0;
        }
    }

    return maxCount > 0 ? -1 : countArr.indexOf(maxVal);
}