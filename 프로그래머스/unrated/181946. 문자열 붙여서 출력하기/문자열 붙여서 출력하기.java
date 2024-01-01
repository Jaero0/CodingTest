import java.io.*;
import java.util.StringTokenizer;

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String a = br.readLine();

        StringTokenizer stn = new StringTokenizer(a);

        StringBuilder sb = new StringBuilder();
        while (stn.hasMoreTokens()) {
            sb.append(stn.nextToken());
        }

        System.out.println(sb);
    }
}