using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEBtestIBAN
{
  public class Check
    {
        public static string ManualString { get; set; }
        public static bool ValidManualLength { get; set; }
        public static bool ValidManual97 { get; set; }
        public static bool IsValid { get; set; }
        public static int chartoNum1 { get; set; }
        public static int chartoNum2 { get; set; }

        public static void ManualCheck()
        {
            if (ManualString.Length == 20)
            {
                ValidManualLength = true;
                FormatString(ManualString, 0);
            }
            else
            {
                ValidManualLength = false;
            }
        }
        public static void FormatString( string Iban, int ManualorFile)
        {
           
                string char1 = Iban.Substring(0, 1); //taking 1st char
                string char2 = Iban.Substring(1, 1); // taking 2nd char
                string checknumbers = Iban.Substring(2, 2); //2 numbers
                string FullIban = Iban; //may be used to print later
                Iban = Iban.Substring(4); // removing 4 chars from the start


                CharToInt(char1.ToUpper(), 0);  //char to numbers (LT..)
                CharToInt(char2.ToUpper(), 1);  // char to numbers

            Iban = Iban + chartoNum1 + chartoNum2 + checknumbers; // adding char numbers and checking numbers to the end of string
            
            decimal FinalNumber = Convert.ToDecimal(Iban);
            if (FinalNumber % 97 == 1)
            {
                 IsValid = true;
                if (ManualorFile == 0)
                {
                    ValidManual97 = IsValid;
                }
            }
            else
            {
                 IsValid = false;
                if (ManualorFile == 0)
                {
                    ValidManual97 = IsValid;
                }
            }

        }
        private static void CharToInt(string c, int x)
        {
            int a;

            switch (c)
            {
                case "A":
                    a = 10;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "B":
                    a = 11;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "C":
                    a = 12;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "D":
                    a = 13;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "E":
                    a = 14;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "F":
                    a = 15;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "G":
                    a = 16;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "H":
                    a = 17;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "I":
                    a = 18;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "J":
                    a = 19;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "K":
                    a = 20;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "L":
                    a = 21;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "M":
                    a = 22;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "N":
                    a = 23;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "O":
                    a = 24;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "P":
                    a = 25;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "Q":
                    a = 26;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "R":
                    a = 27;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "S":
                    a = 28;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "T":
                    a = 29;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "U":
                    a = 30;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "V":
                    a = 31;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "W":
                    a = 32;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "X":
                    a = 33;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "Y":
                    a = 34;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                case "Z":
                    a = 35;
                    if (x == 0)
                    {
                        chartoNum1 = a;
                    }
                    else
                    {
                        chartoNum2 = a;
                    }
                    break;
                default:
                    break;
            }

        }  // giving char numbers

    }
}
