using System;
using EnumsAndProperties;

public class MethodTeacher
{
    
    //Sum using For loop
    public double Sum(double firstNum, double secondNum)
    {
        DayWeek x;
        return firstNum + secondNum;
    }

    //Variable no of arguments
    //Return sum of even numbers from supplied 6 parameters
    public int SumOfEven( params int[] numbers)
    {
        int sum =0;
        foreach( int number in numbers )
        {
            if(number % 2 ==0)
            {
                sum = sum +number;
            }
        }
        return sum;
    }

    
    //Returning miltiple values - Using tuples
    //Method to Find min and max from set of numbers

    internal (int,int)  FindMinMax(int[] numbers)
    {
        int min =numbers[0];
        int max =numbers[0];
        foreach(int num in numbers)
        {
            if(num<min)
            {
                min = num;
            }
            if(num > max)
            {
                max = num;
            }
            
        }
        return (min, max);
    }

    internal void PrintCustomerDetails( string name, byte age, string address)
    {
        Console.Write($"Name: {name}[{age}], Address: {address}");
    }

    public void Sum<T>(T firstNum, T secondNum)
    {
        
    }
}

public class MethodTester
{
    static void Main4()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        
        methodTeacher.SumOfEven(1,2,3,4,5,6,7);
        int[] numbers = new int[] {1,45,87,9,3,0,45,87};
        (int min, int max) result =methodTeacher.FindMinMax(numbers);
        Console.WriteLine($"The minimum value is {result.min} and the maximum is {result.max}");
        methodTeacher.PrintCustomerDetails(age: 20, name: "Kushal", address: "Solu");
        methodTeacher.Sum<float>( 345.5f,34.2f);
    }
}