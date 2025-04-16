// See https://aka.ms/new-console-template for more information
//using System.Runtime.Versioning;
//int i = 1;

//if else condition
//if(i == 1)
//{
//    Console.WriteLine("Number 1");
//}
//else if (i == 2)
//{
//    Console.WriteLine("Number 2");
//}
//else if (i == 3)
//{
//    Console.WriteLine("Number 3");
//}

//else
//{
//    Console.WriteLine(" invalid number");
//}

//switch case
//switch (i)
//{
//    case 1:
//        Console.WriteLine("Number 1");
//        break;
//    case 2:
//        Console.WriteLine("Number 2");
//        break;
//    case 3:
//        Console.WriteLine("Number 3");
//        break;
//    default:
//        Console.WriteLine("Invalid number");
//        break;
//}

//for loop
//for (int j = 0; j < 10; j++)
//{
//    Console.WriteLine("Number " + j);
//}

//array
//int[] numbers = { 1, 2, 3, 4, 5 };
//foreach (int number in numbers)
//{
//    Console.WriteLine("Number " + number);
//}

using System.Reflection.Metadata.Ecma335;

public class Person
{
    public Person(String name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; private set; }
    public string AgeIf18Over()
    {
        string result;
        if (Age >= 18)
        {
            result = "Yes";
        }
        else
        {
            result = "No";
        }

        return result ;


    }

    public void SetAge(int newAge)
    {
        if (newAge > 0) 
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("Invalid age. Age must be a positive number.");
        }
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person("Moe Htet Oo", 20);
        person.Name = "John";  
        person.SetAge(30);
        person.AgeIf18Over();
        person.Introduce(); 
        Console.WriteLine($"Is {person.Name} over 18? {person.AgeIf18Over()}");
        Console.ReadLine();  
    }
}



//string name = "John";
//int age = 30;

//Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");



