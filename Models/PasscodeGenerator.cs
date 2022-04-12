using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomPasscode.Models
{

public static class PasscodeGenerator
{
    public static string Generate()
    {
        Random random = new Random();
        string randomPasscode = "";

        for (int i = 0; i < 15; ++i)
        {
            int randomIndex = random.Next(0, Chars.Length);
            randomPasscode += Chars[randomIndex];
        }

        return randomPasscode;
    }

    static Char[] Chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
        'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
}

}