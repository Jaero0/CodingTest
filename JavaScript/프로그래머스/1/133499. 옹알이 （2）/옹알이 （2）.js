function solution(babbling) {

    const originalBabbling = ["aya", "ye", "woo", "ma"];
    const arr = []

    for (let i = 0; i < babbling.length; i ++) {

        let replaced = babbling[i];

        for (let j = 0; j < originalBabbling.length; j ++) {

            if (replaced.includes(originalBabbling[j])) {
                replaced = replaced.replaceAll(originalBabbling[j], j)
            }
        }

        if (replaced.includes("e") || isNaN(Number(replaced))) {
            arr.push("Nope")
            continue
        }

        let isSequence = false;

        for (let j = 0; j < replaced.length - 1; j++) {

            if (replaced[j] === replaced[j + 1]) {
                isSequence = true;
                break;
            }
        }

        arr.push(!isSequence ? "" : "Nope")
    }

    return arr.filter((s) => s === "").length;
}