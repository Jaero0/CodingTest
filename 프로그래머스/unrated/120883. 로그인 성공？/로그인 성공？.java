class Solution {
    public String solution(String[] id_pw, String[][] db) {
        String answer = "";

        String id = id_pw[0];
        String pw = id_pw[1];

        boolean isPwWrong = true;
        boolean isAllWrong = true;

        for (int i = 0; i < db.length; i++) {

            if (db[i][0].equals(id)) {

                isAllWrong = false;

                if (db[i][1].equals(pw)) {

                    isPwWrong = false;
                    break;
                }
            }
        }

        if (isAllWrong == true) {
            return "fail";
        }
        return isAllWrong == false && isPwWrong == true ? "wrong pw" : "login";
    }
}