function solution(nums) {

    const set = new Set();

    for (const num of nums) {

        set.add(num);

        if (set.size === nums.length / 2) {
            break
        }
    }

    return set.size;
}