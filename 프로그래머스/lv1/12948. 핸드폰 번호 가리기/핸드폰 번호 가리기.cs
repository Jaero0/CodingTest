using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string phone_number)
    {
        StringBuilder sb = new StringBuilder();
        string answer = "";

        char[] numChar = phone_number.ToCharArray();

        for (int i = 0; i < numChar.Length ; i++)
        {
            if (i < numChar.Length-4)
            {
                numChar[i] = '*';
            }
            answer += numChar[i];
        }

        return answer;
    }
}