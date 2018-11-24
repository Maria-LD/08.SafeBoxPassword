import java.util.Scanner;

public class SaveBoxPassword {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

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

        try {

            System.out.print("Enter a NUMBER (from 4 to 144): ");
            int NUMBER = Integer.parseInt(scanner.nextLine());
            while (NUMBER < 4 || NUMBER > 144) {
                System.out.print("Invalid input! NUMBER must be in the range from 4 to 144: ");
                NUMBER = Integer.parseInt(scanner.nextLine());
            }

            int counter = 0;
            String password = "";

            for (int d1 = 0; d1 <= 9; d1++) {
                for (int d2 = 0; d2 <= 9; d2++) {
                    for (int a = 'a'; a <= 'z'; a++) {
                        for (int b = 'a'; b <= 'z'; b++) {
                            for (int c = 'a'; c <= 'z'; c++) {
                                for (int d3 = 0; d3 <= 9; d3++) {
                                    for (int d4 = 0; d4 <= 9; d4++) {

                                        if (d1 * d2 + d3 * d4 == NUMBER && d1 < d2 && d3 > d4) {
                                            if (a + b - c == NUMBER) {
                                                counter++;
                                                password = String.format("Password: %d%d%c%c%c%d%d",
                                                        d1, d2, a, b, c, d3, d4);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (counter >= 2) {
                System.out.println(password);
            } else if (counter < 2 && counter > 0) {
                System.out.println("Sorry! Not enough combinations!");
            } else if (counter == 0) {
                System.out.println("Sorry! No password!");
            }

        } catch (Exception ex) {
            System.out.println("Invalid input! Start the program from the beginning! NUMBER must be in the range from 4 to 144!");
        }

    }
}