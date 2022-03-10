using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures
{
    public static class Switch
    {
        public static void Execute()
        {
            Console.WriteLine($"Classic switch : {OldSwitch(Color.Blue)}");
            Console.WriteLine($"New switch : {NewSwitch(Color.Green)}");
        }

        private static string OldSwitch(Color c)
        {
            switch (c)
            {
                case Color.Red:
                    return "Red Colour";
                    
                case Color.Blue:
                    return "Blue Colour";
                    
                case Color.Green:
                    return "Green Colour";
                    
                case Color.Yellow:
                    return "Yellow Colour";
                    
                case Color.Pink:
                    return "Pink Colour";
                    
                default:
                    return "No Colour";
            }
        }

        private static string NewSwitch(Color c)
        {
            var result = c switch
            {
                Color.Red => "Red Colour",
                Color.Blue => "Blue Colour",
                Color.Green => "Green Colour",
                Color.Yellow => "Yellow Colour",
                Color.Pink => "Pink Colour",
                _ => "No Colour"
            };

            return result;
        }

        public enum Color
        {
            Red,
            Blue,
            Green,
            Yellow,
            Pink
        }

    }
}
