class Solution {
    public String solution(String polynomial) {

        String[] splitPoly = polynomial.split(" ");


        int x = 0;
        int n = 0;

        for (int i = 0; i < splitPoly.length; i++) {

            if (i % 2 == 1) {
                continue;
            }

            String string = splitPoly[i];

            if (string.contains("x")) {

                string = string.replace("x", " 1");

                String[] splitString = string.split(" ");

                if (!splitString[0].isEmpty()) {
                    x += Integer.parseInt(splitString[0]);
                } else {
                    x += Integer.parseInt(splitString[1]);
                }

            } else {

                n += Integer.parseInt(string);
            }
        }

        if (x > 1 && n != 0) {
            return x + "x + " + n;
        } else if (x > 1) {
            return x + "x";
        } else if (x == 1 && n != 0) {
            return "x + " + n;
        } else if (x == 1) {
            return "x";
        } else {
            return String.valueOf(n);
        }
    }
}