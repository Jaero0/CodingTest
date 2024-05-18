class Solution {
    public String[] solution(int n, int[] arr1, int[] arr2) {
        String[] answer = new String[n];

        for (int i = 0; i < n; i++) {
            // OR 연산 후 2진수 문자열로 변환
            String binaryString = Integer.toBinaryString(arr1[i] | arr2[i]);

            // 길이를 n으로 맞추기 위해 앞쪽에 0을 추가
            while (binaryString.length() < n) {
                binaryString = "0".concat(binaryString);
            }

            // 1과 0을 각각 #과 공백으로 변환
            binaryString = binaryString.replaceAll("1", "#");
            binaryString = binaryString.replaceAll("0", " ");

            // 결과를 배열에 저장
            answer[i] = binaryString;
        }

        return answer;
    }
}
