using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class House
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
            if (n > 2 && n <= 100)
            {
               
 
                Roof(n, (n + 1) / 2);
                Fundament(n, n/2);
            }
           
 
        }
        static void Roof(int n,int lines)
        {  
            int stars=2-n%2;
           
            int blanks=(n-stars)/2;
         
 
            for (int i = 1; i <= lines;i++ )
            {
               
                string side = Write("-", blanks);
                Print (side,Write("*", stars));
 
                stars += 2;
                blanks = blanks - 1;
 
            }
           
        }
        static void Fundament(int n,int lines)
        {
            string brick=Write("*",n-2);
 
            for (int i = 1; i <=lines; i++)
            {
                Print("|", brick);
            }
 
        }
        static string Write(string symbol, int times)
        {
            string result="";
 
            for (int i = 1; i <= times; i++)
            {
                result += symbol;
            }
            return result;
        }
        static void Print(string side, string middle)
        {
            Console.WriteLine(side+middle+side);
        }
    }


