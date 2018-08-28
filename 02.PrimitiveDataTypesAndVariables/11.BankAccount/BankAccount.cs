using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BankAccount
    {
    static void Main(string[] args)
        {
        string holderName = "Dimityr Georgiev Jekov";
        string availableMoney = "185$";
        string bankName = "UBB";
        string IBAN = "BG28CITI87562030008210";
        string BIGcode = "UNARHFAR";
        ulong cardNumber1 = (ulong)2021000011112222;
        ulong cardNumber2 = (ulong)2021000011112222;
        ulong cardNumber3 = (ulong)2021000011112222;

        Console.WriteLine(@"
        Holder name -->{0}
        Available money -->{1}
        Bank Name -->{2}
        IBAN -->{3}
        BIG Code -->{4}
        Card Number1 -->{5}
        Card Number2 -->{6}
        Card Number3 -->{7}",
        holderName, availableMoney, bankName, IBAN, BIGcode, cardNumber1, cardNumber2, cardNumber3);
        }
    }
 
