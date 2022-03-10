using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures
{
    public static class InterfaceFeatures
    {
        public static void Show()
        {
            HighSchool f = new HighSchool();
            f.ShowFeatures();

            Primary p = new Primary();
            p.ShowFeatures();
        }
    }

    class HighSchool : ISchool
    {
        public void ShowFeatures()
        {
            Console.WriteLine("High School");
            Console.WriteLine("-----------");

            HighSchool f = new HighSchool();
            f.DressCode();
            ISchool school = f;
            school.ColorOfTye();
            school.ShoeColour("Brown");
            Console.WriteLine(school.CapColor);
        }

        public void DressCode()
        {            
            Console.WriteLine("White Shirt and Blue Jeans");
        }
    }

    class Primary : IPrimarySchool
    {

        public void ShowFeatures()
        {
            Console.WriteLine("Primary School");
            Console.WriteLine("--------------");

            IPrimarySchool primarySchool = new Primary();
            primarySchool.DressCode();
            primarySchool.ColorOfTye();
            primarySchool.ShoeColour("Black");
            Console.WriteLine("Value " + IPrimarySchool.Rank); // static prperty should call like this
            Console.WriteLine(primarySchool.CapColor);
        }
    }
    public interface ISchool
    {
        /// <summary>
        /// 1. Implementing method in Interface
        /// </summary>
        
        void ColorOfTye()
        {
            Console.WriteLine($"Tye color Red");
        }


        /// <summary>
        /// 2. Passing parameter
        /// </summary>
        void ShoeColour(string color)
        {
            Console.WriteLine($"Shoe color {color}");
        }

        /// <summary>
        /// 3. Creating Property
        /// </summary>
        public string CapColor
        { 
            get
            {
                return $"Cap color white  {Environment.NewLine}";
            }
        }

        
        void DressCode();
    }

    public interface IPrimarySchool : ISchool
    {
        /// <summary>
        /// 4. Overriding example
        /// </summary>
        /// 
        void ISchool.DressCode()
        {
            Console.WriteLine("White Shirt and Brown Trowser..  Overriden");
        }

        /// <summary>
        /// 5. If you didn't implemented the property, you will get 0 
        /// </summary>
        static int Rank { get; set; }

    }

}

