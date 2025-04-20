using System;
using System.Globalization;

public class Program
{

    //public class Animal
    //{

    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal is Eating");
    //    }

    //    public virtual void Sleep()
    //    {
    //        Console.WriteLine("Animal is Sleeping");
    //    }

    //}



    //class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Dog Bark");
    //    }
    //    public override void Sleep()
    //    {
    //        Console.WriteLine("Dog is Sleeping");
    //    }
    //}

    //public class Cat : Animal
    //{
    //    public void Meow()
    //    {
    //        Console.WriteLine("Cat Meow");
    //    }

    //}

    //public interface IProgrammingLanguage
    //{
    //    void Java();
    //    void Kotlin();
    //    void Swift();
    //    void CSharp();


    //}
    //public class ProgrammingLanguage : IProgrammingLanguage
    //{
    //    public void Java()
    //    {
    //        Console.WriteLine("Java");
    //    }

    //    public void Kotlin()
    //    {
    //        Console.WriteLine("Kotlin");
    //    }
    //    public void Swift()
    //    {
    //        Console.WriteLine("Swift");
    //    }
    //    public void CSharp()
    //    {
    //        Console.WriteLine("C#");
    //    }
    //}

    //public class JavaEE : ProgrammingLanguage

    //{
    //    public new void Java()
    //    {
    //        Console.WriteLine("JavaEE");
    //    }

    //}



    //public class Caculator
    //{
    //    public int Add (int a , int b)
    //    {
    //        return a + b;
    //    }
    //    public int Add(int a, int b,int c)
    //    {
    //        return a + b +c;
    //    }

    //    public double Add( double a , double b)
    //    {
    //        return a + b;
    //    }
    //}

    //public class FirstClass
    //{
    //    public virtual void pyorkyi(string message)
    //    {
    //        Console.WriteLine("Mingalrpr " + message);
    //    }
    //}



    //public class SecondClass : FirstClass
    //    {
    //        public override void pyorkyi(string message)
    //        {
    //            Console.WriteLine("San Kyi tr Pr " + message);
    //        }
    //    }

    //class Person
    //{
    //    // Private field
    //    private string name;

    //    // Public property
    //    public string Name
    //    {
    //        get { return name; } // Getter
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //            {
    //                name = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Name cannot be empty.");
    //            }
    //        } // Setter

    //    }
    //    // Public method
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Name: {name}");

    //    }


    //}


    //public class BankAccount
    //{
    //    private double balance;

    //    public double Balance
    //    {
    //        get { return balance; }

    //    }
    //    public double Deposit
    //    {
    //        set
    //        {
    //            if (value > 0)
    //            {
    //                balance += value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Deposit amount must be positive.");
    //            }
    //        }
    //    }

    //}


    //public class Product
    //{
    //    private string name;
    //    private double price;

    //    public Product(string name, double price)
    //    {
    //        this.name = name;
    //        this.price = price;
    //    }

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Product Name: {name}, Price: {price}");
    //    }
    //}




    public static void Main (string[] args)
    {
        //Dog dog = new Dog();
        //dog.Eat(); 
        //dog.Bark();
        //dog.Sleep();

        //Cat cat = new Cat();
        //cat.Eat();
        //cat.Meow();

        // ProgrammingLanguage programmingLanguage = new ProgrammingLanguage();
        // JavaEE javaEE = new JavaEE();


        // programmingLanguage.Java();
        // javaEE.Java();
        // programmingLanguage.Kotlin();
        // programmingLanguage.Swift();
        // programmingLanguage.CSharp();

        // Caculator caculator = new Caculator();
        //int firstFunction    =    caculator.Add(2,3);
        //int secondFunction   =    caculator.Add(3,4,5);
        //double thirdFunction =   caculator.Add(2.1, 3.5);

        // Console.WriteLine($"{firstFunction} , {secondFunction} , {thirdFunction}");


        // FirstClass firstClass = new FirstClass();
        // firstClass.pyorkyi("Ko Lynn");
        // SecondClass secondClass = new SecondClass();
        // secondClass.pyorkyi("Ko Lynn");

        // Person person = new Person();
        // person.Name = "John Doe";  // Using the property
        // person.DisplayInfo();


        // BankAccount bankAccount = new BankAccount();
        // bankAccount.Deposit = 1000; // Using the property
        // Console.WriteLine($"Balance: {bankAccount.Balance}");


        // Product product = new Product("Laptop", 1500.00);
        // product.DisplayInfo();


        //LINQ
        //int[] numbers = {1,2,3,4,5 };
        //int result = numbers.FirstOrDefault();
        //decimal num = 100000.99m;
        //Console.WriteLine(num.ToString("n0"));

        //var answer =  numbers.Where(number => number % 2 == 0);

        //Console.WriteLine(result);
        //Console.WriteLine ("Sum is "+ numbers.Sum());

        //Console.WriteLine("Max is " + numbers.Max());

        //Console.WriteLine("Min is " + numbers.Min());

        //Console.WriteLine("Average is " + numbers.Average());

        //Console.WriteLine("Count is " + numbers.Count());

        //var orderBy = numbers.OrderBy(number => number);
        //Console.WriteLine("Order by is: " + string.Join(", ", orderBy));

        //var orderByDescending = numbers.OrderByDescending(number => number);
        //Console.WriteLine("Order by Descending is: " + string.Join(", ", orderByDescending));



        //foreach (var number in answer)
        //{
        //    Console.WriteLine(number);
        //}


        //double value = 1234.5678;

        //Console.WriteLine(value.ToString("C"));  // Currency
        //Console.WriteLine(value.ToString("D"));  // Decimal
        //Console.WriteLine(value.ToString("E"));  // Exponential
        //Console.WriteLine(value.ToString("F"));  // Fixed-point
        //Console.WriteLine(value.ToString("N"));  // Number
        //Console.WriteLine(value.ToString("P"));  // Percent
        //double value = 1234.5678;

        //CultureInfo usCulture = new CultureInfo("en-US");
        //CultureInfo frCulture = new CultureInfo("fr-FR");

        //Console.WriteLine(value.ToString("C", usCulture)); // $1,234.57

        //Console.WriteLine(value.ToString("C", frCulture)); // 1 234,57 €

        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime.ToString("yyyy-MM-dd")); // 2023-10-05



        Console.ReadLine();
    }
}

