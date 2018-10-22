using System;
//Problem 3. Expression
class Expression
{
    static void Main()
    {
        string exp = Console.ReadLine();
        bool Bounds = false;
        double sum = 0;
        double sumBounds = 0;
        int ope = 0;
        int opeBounds = 0;
        foreach (char c in exp)
        {
            if (c == '(')
            {
                Bounds = true;
                continue;
            }
            else if (c == ')')
            {
                Bounds = false;
                switch (ope)
                {
                    case 0: sum += sumBounds; sumBounds = 0; opeBounds = 0; break;
                    case 1: sum -= sumBounds; sumBounds = 0; opeBounds = 0; break;
                    case 2: sum *= sumBounds; sumBounds = 0; opeBounds = 0; break;
                    case 3: sum /= sumBounds; sumBounds = 0; opeBounds = 0; break;
                }
                continue;
            }
            else if (c == '=')
            {
                Console.WriteLine("{0:F2}", sum);
                continue;
            }
            if (Bounds == false)
            {
                int temp = 0;    // for testing purposes 4+6/5+(4*9–8)/7*2=
                switch (c)
                {
                    case '+': ope = 0; break;
                    case '-': ope = 1; break;
                    case '*': ope = 2; break;
                    case '/': ope = 3; break;
                    default: temp = int.Parse(c.ToString()); break;
                }
                if (temp != 0)
                {
                    switch (ope)
                    {
                        case 0: sum += temp; break;
                        case 1: sum -= temp; break;
                        case 2: sum *= temp; break;
                        case 3: sum /= temp; break;
                    }
                }
            }
            else
            {
                int temp = 0;    // for testing purposes 4+6/5+(4*9–8)/7*2= 
                switch (c)
                {
                    case '+': opeBounds = 0; break;
                    case '-': opeBounds = 1; break;
                    case '*': opeBounds = 2; break;
                    case '/': opeBounds = 3; break;
                    default: temp = int.Parse(c.ToString()); break;
                }
                if (temp != 0)
                {
                    switch (opeBounds)
                    {
                        case 0: sumBounds += temp; break;
                        case 1: sumBounds -= temp; break;
                        case 2: sumBounds *= temp; break;
                        case 3: sumBounds /= temp; break;
                    }
                }
            }

        }
    }
}