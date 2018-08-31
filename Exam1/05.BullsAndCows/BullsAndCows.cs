using System;



class BullsAndCows
{
static void Main(string[] args)
    {
    //input
    string guess = Console.ReadLine();
    int targetBulls = int.Parse(Console.ReadLine());
    int targetCows = int.Parse(Console.ReadLine());
    bool hasSolution = false;
    //logic
    string result = "";
    for (int num = 1111; num <= 9999; num++)
        {
        int Bulls = 0;
        int Cows = 0;
        bool[] isVisited = new bool[4];
        string numStr = num.ToString();

        bool hasZero = false;
        for (int i = 0; i < numStr.Length; i++)
            {
            if (numStr[i] == '0')
                {
                hasZero = true;
                }
            }
        if (hasZero)
            {
            continue;
            }


        for (int i = 0; i < numStr.Length; i++)
            {
            if (guess[i] == numStr[i])
                {
                Bulls++;
                isVisited[i] = true;
                }
            }
        for (int i = 0; i < numStr.Length; i++)
            {
            if (!isVisited[i])
                {
                for (int j = 0; j < numStr.Length; j++)
                    {
                        if ((i != j) && !isVisited[j] && (guess[i] == numStr[j]))
                        {
                        Cows++;
                        isVisited[j] = true;
                        }
                    }
                }
            }
        if (targetBulls == Bulls && targetCows == Cows)
            {
            hasSolution = true;
            Console.Write("{0} ", numStr);
            }
        }

    if (!hasSolution)
        {
        Console.WriteLine("No");
        }
    }
}
 
