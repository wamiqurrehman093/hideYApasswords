using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace encryterConsole.classes
{
    class passcode
    {

        static void savePasscode(string passcode, Dictionary<char, char> passKey, string dir)
        {
            encrypt code = new encrypt();
            string encPasscode = code.funcEncrypt(passcode, passKey);
            code.saveEncrypt("Passcode", passcode, dir);
        }

        static bool passcodeINfile(string dir)
        {
            return Regex.IsMatch(dir,@"^Passcode \: \d{3}");

        }
        static string enterPasscode()
        {
            string pass;
            do
            {
                Console.WriteLine("ENTER 3 DIGIT PASSCODE");
                Console.WriteLine("3 digit to acces all passwords");

                pass = Console.ReadLine();
                Console.Clear();
            } while (pass.Length >= 4);
            return pass;
        }
    }
}
