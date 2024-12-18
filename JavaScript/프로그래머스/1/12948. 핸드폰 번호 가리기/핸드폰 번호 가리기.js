function solution(phone_number) {

    const last4 = phone_number.slice(-4);
    const firstFew = "*".repeat(phone_number.length - 4);

    return firstFew + last4
}