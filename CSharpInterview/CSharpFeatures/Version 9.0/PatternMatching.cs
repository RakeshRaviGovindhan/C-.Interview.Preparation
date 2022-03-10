using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures.Version_9._0
{
    public static class PatternMatching
    {
        public static void Execute()
        {
            #region Type Patterns

            Console.WriteLine("\tType Patterns");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("---------------Example 1-----------------\n");
            Console.WriteLine($"Is Teacher : {IsTeacher(new Teacher())}\n");


            Console.WriteLine("---------------Example 2-----------------\n");
            int age = 42;
            string name = "Bassam";
            var userTuple = (age, name);

            // C# 8.0  
            // test if age is an int and name is a string   
            if (userTuple is (int _, string _))
            {
                Console.WriteLine(userTuple.name);
            }

            // C# 9.0  
            // test if age is an int and name is a string   
            if (userTuple is (int, string))
            {
                Console.WriteLine($"Name: {userTuple.name}, Age: {userTuple.age}");
            }

            #endregion

            #region Relational Patterns

            Console.WriteLine("\tRelational Patterns");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("---------------Example 3-----------------\n"); 


            Console.WriteLine($"Life Stage : {GetLifeStage(new Person() { Age = 36})}");

            Console.WriteLine($"Life Stage : {AreYouEarlyAdult(new Person() { Age = 36})}");


            #endregion


            #region Parenthesized patterns

            Console.WriteLine("\tParenthesized patterns");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("---------------Example 4-----------------\n");


            Console.WriteLine($"Is it Letter : {IsLetter1('B')}");

            bool IsLetter1(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

            bool IsLetter2(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

            #endregion

            #region Combinator Patterns

            static LifeStage AreYouEarlyAdult(Person person) => person.Age switch
            {
                4 or <= 6 => LifeStage.EarlyChild,
                6 or <= 12 => LifeStage.MiddleChild,
                > 20 and < 40 => LifeStage.EarlyAdult,
                < 65 => LifeStage.MiddleAdult,
                _ => LifeStage.LateAdult
            };

            Console.WriteLine($"Not a teacher : {IsNotTeacher(new Teacher())}");
            

            #endregion
        }

        // Type Patterns C# Version 8.0
        static bool IsStudent(Person person) => person switch
        {
            Teacher _ => true,
            Student _ => false,
            _ => false
        };

        // Type Patterns C# Version 9.0
        static bool IsTeacher(Person person) => person switch
        {
            Teacher => true,
            Student => false,
            _ => false
        };

        // Relational Patterns C# Version 9.0
        static LifeStage GetLifeStage(Person person) => person.Age switch
        {
            < 0 => LifeStage.Prenatal,
            < 2 => LifeStage.Infant,
            < 4 => LifeStage.Toddler,
            < 6 => LifeStage.EarlyChild,
            < 12 => LifeStage.MiddleChild,
            < 20 => LifeStage.Adolescent,
            < 40 => LifeStage.EarlyAdult,
            < 65 => LifeStage.MiddleAdult,
            _ => LifeStage.LateAdult
        };

        // Combinator Patterns C# Version 9.0 
        static bool IsNotTeacher(Person person) => person switch
        {
            not Teacher => true,
            not  Student => false
        };


    }

    class Person { public int Age { get; set; }}

    class Teacher : Person { }

    class Student : Person { }

    public enum LifeStage
    {
        Prenatal,
        Infant,
        Toddler,
        EarlyChild,
        MiddleChild,
        Adolescent,
        EarlyAdult,
        MiddleAdult,
        LateAdult
    }

}
