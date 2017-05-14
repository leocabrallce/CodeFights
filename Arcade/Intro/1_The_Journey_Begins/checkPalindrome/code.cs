bool checkPalindrome(string inputString)
    {
        char[] charArray1 = inputString.ToCharArray();
        char[] charArray2 = inputString.ToCharArray();
        Array.Reverse(charArray1);
        int x = 0;
        while (x < charArray1.Length)
        {
            if (charArray1[x] != charArray2[x])
                return false;
            if (charArray1[x] == charArray2[x])
                ++x;
        }
        return true;
    }