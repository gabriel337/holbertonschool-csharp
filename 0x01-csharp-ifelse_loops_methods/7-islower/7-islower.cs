using System;

class Character
{
    public static bool IsLower(char c)
    {
        for (char lowerLetter = 'a'; lowerLetter <= 'z'; lowerLetter++)
        {
            if (lowerLetter == c)
            {
                return true;
            }
        }
        return false;
    }
}