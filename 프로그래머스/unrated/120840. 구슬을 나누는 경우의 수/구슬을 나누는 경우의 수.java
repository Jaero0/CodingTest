import java.math.BigInteger;

class Solution {
    public BigInteger solution(int balls, int share) {
        BigInteger changable = BigInteger.valueOf(1);

        BigInteger n = null;
        BigInteger m = null;
        BigInteger nSubtractM = null;

        for (int i = 1; i <= balls; i++) {
            changable = changable.multiply(BigInteger.valueOf(i));

            if (i == share) {
                m = changable;
            }
            if (i == balls - share) {
                nSubtractM = changable;
            }
        }

        n = changable;

        if (n != null && m != null && nSubtractM != null) {
            changable = n.divide(m.multiply(nSubtractM));
        } else {
            changable = BigInteger.valueOf(1);
        }

        return changable;
    }
}