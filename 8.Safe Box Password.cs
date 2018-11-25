using System;

class SafeBoxPassword
{
    static void Main()
    {
        /*Help John to find the magic elixir and become the best programmer ever!
        John dreams of being the best programmer on the planet.
        A magic elixir which is locked in a safe box will help him to fulfill his dream.
        The safe box has a password.
        John knows only a NUMBER [4..... 144] related to the password
        and should find out by himself all the password digits following these instructions:
        The password's format is "d1d2abcd3d4" where "d1", "d2", "d3" and "d4" are digits (0-9)and "a", "b" and "c" are letters(a-z).
        The conditions for the digits are: "NUMBER = d1 * d2 + d3 * d4"; "d1 < d2"; "d3 > d4".
        The conditions for the letters are: "a > b < c" and "NUMBER = a * b - c". Use the numeric value of "a", "b" and "c" in the ASCII Table).
        The password is the second combination of digits.
        Sadly, it doesn't work with many numbers - 112, 114, 126, etc*/

        try
        {
            Console.Write("Enter a NUMBER (from 4 to 144): ");
            int NUMBER = int.Parse(Console.ReadLine());
            while (NUMBER < 4 || NUMBER > 144)
            {
                Console.Write("Invalid input! NUMBER must be in the range from 4 to 144: ");
                NUMBER = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            String password = "";

            for (int d1 = 0; d1 <= 9; d1++)
            {
                for (int d2 = 0; d2 <= 9; d2++)
                {
                    for (char a = 'a'; a <= 'z'; a++)
                    {
                        for (char b = 'a'; b <= 'z'; b++)
                        {
                            for (char c = 'a'; c <= 'z'; c++)
                            {
                                for (int d3 = 0; d3 <= 9; d3++)
                                {
                                    for (int d4 = 0; d4 <= 9; d4++)
                                    {

                                        if (d1 * d2 + d3 * d4 == NUMBER && d1 < d2 && d3 > d4)
                                        {
                                            if ((int)a + (int)b - (int)c == NUMBER)
                                            {
                                                counter++;
                                                password = $"Password: {d1}{d2}{a}{b}{c}{d3}{d4}";
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (counter >= 2)
            {
                Console.WriteLine(password);
            }
            else if (counter < 2 && counter > 0)
            {
                Console.WriteLine("Sorry! Not enough combinations!");
            }
            else if (counter == 0)
            {
                Console.WriteLine("Sorry! No password!");
            }
        }

        catch
        {
            Console.WriteLine("Invalid input! Start the program from the beginning! NUMBER must be in the range from 4 to 144!");
        }

    }
}