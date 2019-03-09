using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace encryterConsole 
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> enkey = new Dictionary<char, char>();

            enkey.Add('q', 'Z');
            enkey.Add('w', 'X');
            enkey.Add('e', 'C');
            enkey.Add('r', 'V');
            enkey.Add('t', 'B');
            enkey.Add('y', 'N');

            enkey.Add('u', '6');

            enkey.Add('i', 'Q');
            enkey.Add('o', 'W');
            enkey.Add('a', 'E');
            enkey.Add('s', 'R');
            enkey.Add('d', 'T');
            enkey.Add('f', 'Y');
            enkey.Add('g', 'U');
            enkey.Add('h', 'I');
            enkey.Add('j', 'O');
            enkey.Add('k', 'P');
         
            enkey.Add('l', '@');
            enkey.Add('z', '-');
            enkey.Add('x', '_');
         
            enkey.Add('c', '7');
            enkey.Add('v', '2');
            enkey.Add('b', '3');
            enkey.Add('n', '4');
            enkey.Add('m', '5');

            enkey.Add('Q', 'a');
            enkey.Add('W', 's');
            enkey.Add('E', 'd');
            enkey.Add('R', 'f');
            enkey.Add('T', 'g');
            enkey.Add('Y', 'h');
            enkey.Add('U', 'j');
            enkey.Add('I', 'k');
            enkey.Add('O', 'l');
            enkey.Add('P', 'z');
            enkey.Add('A', 'x');
            enkey.Add('S', 'c');
            enkey.Add('D', 'v');
            enkey.Add('F', 'b');
            enkey.Add('G', 'n');
            enkey.Add('H', 'm');
            enkey.Add('J', 'q');
            enkey.Add('K', 'w');
            enkey.Add('L', 'e');
            enkey.Add('Z', 'r');
            enkey.Add('X', 't');
            enkey.Add('C', 'y');
            enkey.Add('V', 'u');
            enkey.Add('B', 'i');
            enkey.Add('N', 'o');
            enkey.Add('M', 'p');

            enkey.Add('1', 'L');
            enkey.Add('2', 'K');
            enkey.Add('3', 'J');
            enkey.Add('4', 'H'); 
            enkey.Add('5', 'G');
            enkey.Add('6', 'F');
            enkey.Add('7', 'D');
            enkey.Add('8', 'S'); 
            enkey.Add('9', 'A');
            enkey.Add('0', '1');

            enkey.Add('-', '.');
            enkey.Add('@', '&');
            enkey.Add('_', '8');
            enkey.Add('.', 'M');
            
            string filename = @"D:\encryptedCode.txt";
            
            Console.WriteLine("Press \" e \" if you wanna Enter Email and Password :");
            
            Console.WriteLine();
            
            Console.WriteLine("Press \" d \" if you wana Decrypt the Password :");
             
            string decision = Console.ReadLine();

            if (decision == "e" || decision == "E")
            {
                encrypt s = new encrypt();
                Console.WriteLine("User chose to enter data......");
                Console.WriteLine();
                

                Console.WriteLine("Enter email :");
                string email = Console.ReadLine();

                Console.WriteLine("Enter password :");
                string password = Console.ReadLine();


                string a = s.funcEncrypt(password, enkey);
                s.saveEncrypt(email, a, filename);
            }

            else if (decision == "d" || decision == "D")
            {
                decrypt c = new decrypt();
                Console.WriteLine("You need a 3 digit Passcode to decrypt");
            s: Console.WriteLine("So...");
            int count = 1;
                Console.WriteLine("press \"y\" if u have the Passcode press \"n\" if you dont have the code :");
                count++;
                if (count == 3)
                {
                    bye();
                }
                else
                {

                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {
                        const string passCode = "098";

                        Console.WriteLine("Enter passcode :");
                        string userPasscode = Console.ReadLine();

                        if (userPasscode == passCode)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter Encrypted Password :");

                            string userPassword = Console.ReadLine();
                            string res = c.funcDecrypt(userPassword, enkey);

                            Console.WriteLine();
                            Console.WriteLine("Decrypted Pasword : \" {0} \" ", res);
                            Console.ReadLine();
                        }
                        else if (userPasscode != passCode)
                        {
                            Console.Write("Invalid Passcode...");
                            goto s;
                        }
                    }
                    else if (yn == "n" || yn != "y")
                    {
                        Console.WriteLine();

                        bye();

                    }
                }

            }
            else
            {
                bye();
            }
           
        }
        static void bye()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.Write("BYE...");
                Thread.Sleep(1000);
            }
        }

    }
}
