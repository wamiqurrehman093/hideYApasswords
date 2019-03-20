using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
namespace encryterConsole.classes
{
   public class passcode
    {
      
        public void savePasscode(string passcode, Dictionary<char, char> passKey, string dir)
        {
            encrypt code = new encrypt();
            string encPasscode = code.funcEncrypt(passcode, passKey);
            code.saveEncrypt("Passcode", encPasscode, dir);
        }
        public  string decryptPasscode(string passcode, Dictionary<char, char> passKey)
        {
            string decPasscode = "";
            decrypt code = new decrypt();
            return decPasscode = code.funcDecrypt(passcode, passKey);
        }

        public  bool passcodeINfile(string dir)
        {
            StreamReader reader = new StreamReader(dir);
            Regex reg = new Regex(@"^passcode \: \w {3}$");
            string line=reader.ReadLine();
            Match passcodeMatch = reg.Match(line);
            return (passcodeMatch.Success);
            
        }
        public  string enterPasscode()
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
        public  string fetchPasscodeFromDirectory(string dir)
        {
            string passCode="";
            StreamReader reader = new StreamReader(dir);
            string line=reader.ReadLine();
            foreach (var s in Regex.Split(line, @"Passcode : "))
            {
               passCode = passCode + s;
            }
               
           
            return passCode;

        }

        public string fetchPasswordFromDirectory(string dir, string email)
        {
            string passWord = "";
            StreamReader reader = new StreamReader(dir);
            Regex reg = new Regex(email + @".+$");
            string line = reader.ReadToEnd();
            Match emailMatch = reg.Match(line);
            if (emailMatch.Success)
            {
                string Fetchemail = emailMatch.ToString();
                foreach (var s in Regex.Split(Fetchemail, @"^.+\@\w+\.com : "))
                {
                    passWord = passWord + s;
                }

            }
            else
                passWord = "No match for email";
            return passWord;

        }

    }
}
