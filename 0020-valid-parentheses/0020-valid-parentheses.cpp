class Solution {
public:
    bool isValid(string s) {
        stack<char> st;

        bool isTrue = true;

        for(char c : s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                st.push(c);
                continue;
            }

            if (c == ')')
            {
                if (st.size() > 0 && st.top() == '(')
                {
                    st.pop();
                    continue;
                }
            }

            if (c == '}')
            {
                if (st.size() > 0 && st.top() == '{')
                {
                    st.pop();
                    continue;
                }
            }

            if (c == ']')
            {
                if (st.size() > 0 && st.top() == '[')
                {
                    st.pop();
                    continue;
                }
            }

            isTrue = false;
            break;
        }

        return st.size() > 0 || isTrue == false ? false : true;
    }
};