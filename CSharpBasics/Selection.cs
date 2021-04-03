using System;

class SelectionStatement
{
    static void Main2()
    {
        SelectionStatement ss = new SelectionStatement();
        ss.LearnSwitch();
        
    }
    void LearnIfElse()
    {

        Console.WriteLine("Enter any number:");
        string input = Console.ReadLine();
        //converting string to byte using parse
        byte x = byte.Parse(input);

        if (x== 23)
        {
            Console.WriteLine("X is equal to 23");
        }
        else if(x == 50)
        {
            Console.WriteLine("50 it is then");
        }
        else 
        {
            Console.Write("it wasn\'t 23");
        }
    }

    void LearnSwitch()
    {
        char option = 'y';

        switch (option)
        {
            case 'n':
                Console.WriteLine("the option was no");
                break;

            case 'y':
            case 'a':
                Console.Write("the option was yes");
                break;

            case 'z':
                Console.WriteLine("option was gay");
                break;

            
            default:
                break;
        }
        
    }
}