namespace Vin_Fletcher_s_Arrows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arrow type (steel, wood, obsidian):");
            string typeInp = Console.ReadLine();
            Console.WriteLine("Enter fletching type (plastic, turkey, goose):");
            string fletchInp = Console.ReadLine();
            Console.WriteLine("Enter length (between 60 and 100):");
            float lengthInp = float.Parse(Console.ReadLine());


            Arrow arrow = new Arrow(typeInp, fletchInp, lengthInp);
            Console.WriteLine($"Arrow cost: {arrow.GetCost()} gold");

        }

        public class Arrow
        {
            //Class Vars
            private string type;
            private string fletch;
            private float length;

            //gets & Sets
            private Arrow(string type, string fletch, float length)
            {
                ArrowType = type;
                FletchType = fletch;
                Length = length;
            }
            private string ArrowType
            {
                get { return type; }
                set
                {
                    if (value == "steel" || value == "wood" || value == "obsidian")
                        type = value;
                }
            }

            private string FletchType
            {
                get { return fletch; }
                set
                {
                    if (value == "plastic" || value == "turkey" || value == "goose")
                        fletch = value;
                }
            }

            private float Length
            {
                get { return length; }
                set
                {
                    if (value >= 60 && value <= 100)
                        length = value;
                }
            }

            private double GetCost()
            {
                double cost = 0;

                if (type == "steel") cost += 10;
                else if (type == "wood") cost += 3;
                else if (type == "obsidian") cost += 5;

                if (fletch == "plastic") cost += 10;
                else if (fletch == "turkey") cost += 5;
                else if (fletch == "goose") cost += 3;

                cost += length * 0.05;

                return cost;
            }
        }
    }
}